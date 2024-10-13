using DataPaintLibrary.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Extensions
{
    public static class DataTableExtensions
    {
        // Filter a DataTable based on a column value
        public static DataTable FilterByColumnValue(this DataTable table, string columnName, object value)
        {
            var filteredRows = table.AsEnumerable()
                .Where(row => row.Field<object>(columnName)?.Equals(value) == true);

            return filteredRows.CopyToDataTable();
        }

        // Filter a DataTable for values greater than a specified value
        public static DataTable FilterGreaterThan(this DataTable table, string columnName, object value)
        {
            var filteredRows = table.AsEnumerable()
                .Where(row => Comparer.Default.Compare(row.Field<object>(columnName), value) > 0);

            return filteredRows.CopyToDataTable();
        }

        // Filter a DataTable for values less than a specified value
        public static DataTable FilterLessThan(this DataTable table, string columnName, object value)
        {
            var filteredRows = table.AsEnumerable()
                .Where(row => Comparer.Default.Compare(row.Field<object>(columnName), value) < 0);

            return filteredRows.CopyToDataTable();
        }

        // Merge two DataTables based on a common column
        public static DataTable MergeByColumn(this DataTable firstTable, DataTable secondTable, string columnName)
        {
            var mergedData = from firstRow in firstTable.AsEnumerable()
                             join secondRow in secondTable.AsEnumerable()
                             on firstRow.Field<object>(columnName) equals secondRow.Field<object>(columnName)
                             select firstRow.ItemArray.Concat(secondRow.ItemArray).ToArray();

            DataTable mergedTable = new DataTable();
            // Add columns from both tables
            foreach (DataColumn column in firstTable.Columns)
            {
                mergedTable.Columns.Add(column.ColumnName, column.DataType);
            }
            foreach (DataColumn column in secondTable.Columns)
            {
                mergedTable.Columns.Add(column.ColumnName, column.DataType);
            }

            foreach (var row in mergedData)
            {
                mergedTable.Rows.Add(row);
            }

            return mergedTable;
        }

        // Example of date matching
        public static DataTable FilterByDate(this DataTable table, string dateColumnName, DateTime startDate, DateTime endDate)
        {
            var filteredRows = table.AsEnumerable()
                .Where(row => row.Field<DateTime>(dateColumnName) >= startDate && row.Field<DateTime>(dateColumnName) <= endDate);

            return filteredRows.CopyToDataTable();

        }

        public static DataTable SortDataTable(this DataTable table, string[] columnNames, bool[] ascending)
        {
            var sortedRows = table.AsEnumerable();

            for (int i = 0; i < columnNames.Length; i++)
            {
                var columnName = columnNames[i];
                sortedRows = ascending[i]
                    ? sortedRows.OrderBy(row => row.Field<object>(columnName))
                    : sortedRows.OrderByDescending(row => row.Field<object>(columnName));
            }

            return sortedRows.CopyToDataTable();
        }

        public static DataTable GroupDataTable(this DataTable table, string[] groupByColumns, string aggregateColumn)
        {
            var groupedData = table.AsEnumerable()
                .GroupBy(row => new
                {
                    Key = string.Join("_", groupByColumns.Select(col => row[col]))
                })
                .Select(g => new
                {
                    Key = g.Key,
                    Count = g.Count(),
                    Sum = g.Sum(row => row.Field<decimal>(aggregateColumn)) // Change type as needed
                });

            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Key", typeof(string));
            resultTable.Columns.Add("Count", typeof(int));
            resultTable.Columns.Add("Sum", typeof(decimal));

            foreach (var group in groupedData)
            {
                resultTable.Rows.Add(group.Key, group.Count, group.Sum);
            }

            return resultTable;
        }

        public static DataTable AddCalculatedField(this DataTable table, string newFieldName, Func<DataRow, object> calculateFunc)
        {
            table.Columns.Add(newFieldName, typeof(object));

            foreach (DataRow row in table.Rows)
            {
                row[newFieldName] = calculateFunc(row);
            }

            return table;
        }

        public static DataTable ConvertColumnType(this DataTable table, string columnName, Type newType)
        {
            var tempTable = new DataTable();

            foreach (DataColumn column in table.Columns)
            {
                tempTable.Columns.Add(column.ColumnName, column.ColumnName == columnName ? newType : column.DataType);
            }

            foreach (DataRow row in table.Rows)
            {
                var newRow = tempTable.NewRow();
                foreach (DataColumn column in table.Columns)
                {
                    newRow[column.ColumnName] = column.ColumnName == columnName
                        ? Convert.ChangeType(row[column], newType)
                        : row[column];
                }
                tempTable.Rows.Add(newRow);
            }

            return tempTable;
        }

        public static DataTable JoinDataTables(this DataTable leftTable, DataTable rightTable, string leftColumn, string rightColumn, string joinType)
        {
            var joinedRows = joinType switch
            {
                "INNER" => from left in leftTable.AsEnumerable()
                           join right in rightTable.AsEnumerable()
                           on left.Field<object>(leftColumn) equals right.Field<object>(rightColumn)
                           select left.ItemArray.Concat(right.ItemArray).ToArray(),

                "LEFT" => from left in leftTable.AsEnumerable()
                          join right in rightTable.AsEnumerable().DefaultIfEmpty()
                          on left.Field<object>(leftColumn) equals right?.Field<object>(rightColumn) ?? DBNull.Value
                          select left.ItemArray.Concat(right?.ItemArray ?? new object[rightTable.Columns.Count]).ToArray(),

                _ => throw new ArgumentException("Invalid join type"),
            };

            var resultTable = new DataTable();
            foreach (var column in leftTable.Columns.Cast<DataColumn>().Concat(rightTable.Columns.Cast<DataColumn>()))
            {
                resultTable.Columns.Add(column.ColumnName, column.DataType);
            }

            foreach (var row in joinedRows)
            {
                resultTable.Rows.Add(row);
            }

            return resultTable;
        }

        public static DataTable RemoveDuplicates(this DataTable table, string[] columns)
        {
            var distinctRows = table.AsEnumerable()
                .GroupBy(row => new { Key = string.Join("_", columns.Select(c => row[c])) })
                .Select(g => g.First());

            return distinctRows.CopyToDataTable();
        }

        public static void ExecuteWithLogging(this ILoggerService loggerService, Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
            }
        }
    }
}
