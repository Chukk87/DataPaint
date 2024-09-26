using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Enums;

namespace DataPaintLibrary.Services.Classes
{
    public class ClassBuilderService : IClassBuilderService
    {
        public List<OwnerGroup> BuildOwnerGroups(DataTable table)
        {
            var groupOwnerList = new List<OwnerGroup>();

            foreach (DataRow dr in table.AsEnumerable())
            {
                var ownerGroup = new OwnerGroup(
                    dr.Field<int?>("Id") ?? 0, // Id
                    dr.Field<string>("GroupName") ?? string.Empty, // Name
                    dr.Field<string>("ContactEmail"), // ContactEmail
                    dr.Field<string>("PhoneNumber")  // PhoneNumber
                );

                groupOwnerList.Add(ownerGroup);
            }

            return groupOwnerList;
        }

        public List<DataInput> BuildDataInputs(DataTable inputDataTable, DataTable inputSheetTable)
        {
            var dataInputList = new List<DataInput>();

            // Group inputSheetTable by DataInputId to avoid repeatedly scanning it
            var sheetGroups = inputSheetTable.AsEnumerable()
                                             .GroupBy(row => row.Field<int>("DataInputId"))
                                             .ToDictionary(g => g.Key, g => g.ToList());

            foreach (DataRow idt in inputDataTable.AsEnumerable())
            {
                var dataInput = new DataInput(
                    id: idt.Field<int>("Id"),
                    name: idt.Field<string>("InputName") ?? string.Empty,
                    ownerGroupId: idt.Field<int>("OwnerGroupId"),
                    extractionType: (ExtractionType)idt.Field<int>("ExtractionTypeId"),
                    type: (DataType)idt.Field<int>("DataTypeId"),
                    location: idt.Field<string>("Location") ?? string.Empty
                );

                // Initialize the Sheets list
                if (sheetGroups.TryGetValue(dataInput.Id, out var filteredSheets))
                {
                    foreach (var ist in filteredSheets)
                    {
                        var sheet = new SheetInput(
                            sheetName: ist.Field<string>("SheetName") ?? string.Empty,
                            includeHeader: ist.Field<bool?>("IncludeHeader") ?? false,
                            startRow: ist.Field<int>("StartRow"),
                            endRow: ist.Field<int>("EndRow"),
                            startColumn: ist.Field<int>("StartColumn"),
                            endColumn: ist.Field<int>("EndColumn")
                        );

                        // Add the sheet to the DataInput's Sheets collection
                        dataInput.Sheets.Add(sheet);
                    }
                }

                dataInputList.Add(dataInput);
            }

            return dataInputList;
        }
    }
}