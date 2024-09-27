using System.Collections.Generic;
using System.Data;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Enums;
using Moq;
using Xunit;

namespace DataPaintLibraryTests.Services.Interfaces
{
    public class ClassBuilderServiceTests
    {
        private readonly Mock<IClassBuilderService> _classBuilderServiceMock;

        public ClassBuilderServiceTests()
        {
            _classBuilderServiceMock = new Mock<IClassBuilderService>();
        }

        [Fact]
        public void BuildOwnerGroups_ShouldReturnCorrectListOfOwnerGroups()
        {
            // Arrange
            var ownerGroupDataTable = new DataTable();
            ownerGroupDataTable.Columns.Add("Id", typeof(int));
            ownerGroupDataTable.Columns.Add("Name", typeof(string));
            ownerGroupDataTable.Columns.Add("ContactEmail", typeof(string));
            ownerGroupDataTable.Columns.Add("PhoneNumber", typeof(string));

            ownerGroupDataTable.Rows.Add(1, "Group A", "groupa@test.com", "123-456-7890");
            ownerGroupDataTable.Rows.Add(2, "Group B", "groupb@test.com", "098-765-4321");

            var expectedOwnerGroups = new List<OwnerGroup>
            {
                new OwnerGroup(1, "Group A", "groupa@test.com", "123-456-7890"),
                new OwnerGroup(2, "Group B", "groupb@test.com", "098-765-4321")
            };

            _classBuilderServiceMock.Setup(s => s.BuildOwnerGroups(ownerGroupDataTable))
                .Returns(expectedOwnerGroups);

            // Act
            var result = _classBuilderServiceMock.Object.BuildOwnerGroups(ownerGroupDataTable);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(expectedOwnerGroups[0].Id, result[0].Id);
            Assert.Equal(expectedOwnerGroups[1].Name, result[1].Name);
        }

        [Fact]
        public void BuildDataInputs_ShouldReturnCorrectListOfDataInputs()
        {
            // Arrange
            var dataInputDataTable = new DataTable();
            dataInputDataTable.Columns.Add("Id", typeof(int));
            dataInputDataTable.Columns.Add("InputName", typeof(string));
            dataInputDataTable.Columns.Add("OwnerGroupId", typeof(int));
            dataInputDataTable.Columns.Add("ExtractionTypeId", typeof(int));
            dataInputDataTable.Columns.Add("DataTypeId", typeof(int));
            dataInputDataTable.Columns.Add("Location", typeof(string));

            dataInputDataTable.Rows.Add(1, "Input A", 1, 0, 1, @"C:\Data\InputA.xlsx");
            dataInputDataTable.Rows.Add(2, "Input B", 1, 1, 2, @"C:\Data\InputB.xlsx");

            var sheetInputDataTable = new DataTable();
            sheetInputDataTable.Columns.Add("DataInputId", typeof(int));
            sheetInputDataTable.Columns.Add("SheetName", typeof(string));
            sheetInputDataTable.Columns.Add("IncludeHeader", typeof(bool));
            sheetInputDataTable.Columns.Add("StartRow", typeof(int));
            sheetInputDataTable.Columns.Add("EndRow", typeof(int));
            sheetInputDataTable.Columns.Add("StartColumn", typeof(int));
            sheetInputDataTable.Columns.Add("EndColumn", typeof(int));

            sheetInputDataTable.Rows.Add(1, "Sheet1", true, 1, 10, 1, 5);
            sheetInputDataTable.Rows.Add(1, "Sheet2", false, 2, 12, 2, 6);

            var expectedDataInputs = new List<DataInput>
            {
                new DataInput(1, "Input A", 1, ExtractionType.Excel, DataType.Dynamic, @"C:\Data\InputA.xlsx"),
                new DataInput(2, "Input B", 1, ExtractionType.Excel, DataType.Static, @"C:\Data\InputB.xlsx")
            };

            // Adding SheetInput to DataInput using the public Add method
            expectedDataInputs[0].Sheets.Add(new SheetInput("Sheet1", true, 1, 10, 1, 5));
            expectedDataInputs[0].Sheets.Add(new SheetInput("Sheet2", false, 2, 12, 2, 6));

            _classBuilderServiceMock.Setup(s => s.BuildDataInputs(dataInputDataTable, sheetInputDataTable))
                .Returns(expectedDataInputs);

            // Act
            var result = _classBuilderServiceMock.Object.BuildDataInputs(dataInputDataTable, sheetInputDataTable);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(expectedDataInputs[0].Id, result[0].Id);
            Assert.Equal(expectedDataInputs[0].Sheets.Count, result[0].Sheets.Count);
            Assert.Equal(expectedDataInputs[1].Location, result[1].Location);

            // Assert on specific SheetInput fields
            var firstSheet = result[0].Sheets[0];
            Assert.Equal("Sheet1", firstSheet.SheetName);
            Assert.True(firstSheet.IncludeHeader);
            Assert.Equal(1, firstSheet.StartRow);
            Assert.Equal(10, firstSheet.EndRow);
            Assert.Equal(1, firstSheet.StartColumn);
            Assert.Equal(5, firstSheet.EndColumn);
            Assert.NotNull(firstSheet.FormattedTable);  // Ensuring FormattedTable is initialized
        }
    }
}