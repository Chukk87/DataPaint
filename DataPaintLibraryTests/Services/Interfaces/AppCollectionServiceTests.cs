using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Xunit;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Enums;

namespace DataPaintLibraryTests.Services.Interfaces
{
    public class AppCollectionServiceTests
    {
        private readonly Mock<ISqlService> _mockSqlService;
        private readonly Mock<IClassBuilderService> _mockClassBuilderService;
        private readonly AppCollectionService _appCollectionService;

        public AppCollectionServiceTests()
        {
            _mockSqlService = new Mock<ISqlService>();
            _mockClassBuilderService = new Mock<IClassBuilderService>();
            _appCollectionService = new AppCollectionService(_mockSqlService.Object, _mockClassBuilderService.Object);
        }

        [Fact]
        public async Task GetAllOwnerGroups_ReturnsExpectedOwnerGroups()
        {
            // Arrange
            var ownerGroupsTable = new DataTable(); // Mock the DataTable returned from SQL
            var expectedOwnerGroups = new List<OwnerGroup>
            {
                new OwnerGroup(1, "Group A", "group1@example.com", "1234567890"),
                new OwnerGroup(2, "Group B", "group2@example.com", "0987654321")
            };

            _mockSqlService.Setup(x => x.GetOwnerGroupsAsync())
                .ReturnsAsync(ownerGroupsTable);
            _mockClassBuilderService.Setup(x => x.BuildOwnerGroups(ownerGroupsTable))
                .Returns(expectedOwnerGroups);

            // Act
            var result = await _appCollectionService.GetAllOwnerGroupsAsync();

            // Assert
            _mockSqlService.Verify(x => x.GetOwnerGroupsAsync(), Times.Once);
            _mockClassBuilderService.Verify(x => x.BuildOwnerGroups(ownerGroupsTable), Times.Once);
            Assert.Equal(expectedOwnerGroups, result);
        }

        [Fact]
        public async Task GetAllDataInput_ReturnsExpectedDataInputs()
        {
            // Arrange
            var dataInputTable = new DataTable(); // Mock the DataInput DataTable
            var sheetInputTable = new DataTable(); // Mock the SheetInput DataTable
            var expectedDataInputs = new List<DataInput>
            {
                new DataInput(1, "Data Input 1", 1, ExtractionType.Excel, DataType.Dynamic, "Location1.xlsx"),
                new DataInput(2, "Data Input 2", 2, ExtractionType.CSV, DataType.Static, "Location2.csv")
            };

            _mockSqlService.Setup(x => x.GetSqlDataInputTableAsync())
                .ReturnsAsync(dataInputTable);
            _mockSqlService.Setup(x => x.GetSqlSheetInputTableAsync())
                .ReturnsAsync(sheetInputTable);
            _mockClassBuilderService.Setup(x => x.BuildDataInputs(dataInputTable, sheetInputTable))
                .Returns(expectedDataInputs);

            // Act
            var result = await _appCollectionService.GetAllDataInputAsync();

            // Assert
            _mockSqlService.Verify(x => x.GetSqlDataInputTableAsync(), Times.Once);
            _mockSqlService.Verify(x => x.GetSqlSheetInputTableAsync(), Times.Once);
            _mockClassBuilderService.Verify(x => x.BuildDataInputs(dataInputTable, sheetInputTable), Times.Once);
            Assert.Equal(expectedDataInputs, result);
        }

        [Fact]
        public void OwnerGroup_ThrowsException_ForInvalidId()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new OwnerGroup(0, "Invalid Group")); // Id must be greater than 0
        }

        [Fact]
        public void OwnerGroup_ThrowsException_ForEmptyName()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new OwnerGroup(1, "")); // Name cannot be empty
        }

        [Fact]
        public void OwnerGroup_CreatesValidOwnerGroup()
        {
            // Arrange
            var ownerGroup = new OwnerGroup(1, "Valid Group", "valid@example.com", "1234567890");

            // Assert
            Assert.Equal(1, ownerGroup.Id);
            Assert.Equal("Valid Group", ownerGroup.Name);
            Assert.Equal("valid@example.com", ownerGroup.ContactEmail);
            Assert.Equal("1234567890", ownerGroup.PhoneNumber);
        }

        [Fact]
        public void OwnerGroup_ValidatesToStringAndEquals()
        {
            // Arrange
            var ownerGroupA = new OwnerGroup(1, "Group A", "groupA@example.com", "1234567890");
            var ownerGroupB = new OwnerGroup(1, "Group A", "groupA@example.com", "1234567890");

            // Act
            var toStringResult = ownerGroupA.ToString();
            var isEqual = ownerGroupA.Equals(ownerGroupB);

            // Assert
            Assert.Equal("OwnerGroup [Id=1, Name=Group A, ContactEmail=groupA@example.com, PhoneNumber=1234567890]", toStringResult);
            Assert.True(isEqual);
        }
    }
}