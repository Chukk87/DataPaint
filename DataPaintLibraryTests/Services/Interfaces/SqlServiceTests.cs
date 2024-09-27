using System.Data;
using System.Threading.Tasks;
using DataPaintLibrary.Services.Interfaces;
using Moq;
using Xunit;

namespace DataPaintLibraryTests.Services.Interfaces
{
    public class SqlServiceTests
    {
        private readonly Mock<ISqlService> _sqlServiceMock;

        public SqlServiceTests()
        {
            _sqlServiceMock = new Mock<ISqlService>();
        }

        [Fact]
        public async Task GetOwnerGroups_ShouldReturnValidDataTable()
        {
            // Arrange
            var mockDataTable = new DataTable();
            mockDataTable.Columns.Add("Id", typeof(int));
            mockDataTable.Columns.Add("Name", typeof(string));
            mockDataTable.Rows.Add(1, "Owner Group 1");
            mockDataTable.Rows.Add(2, "Owner Group 2");

            _sqlServiceMock.Setup(s => s.GetOwnerGroups())
                           .ReturnsAsync(mockDataTable);

            // Act
            var result = await _sqlServiceMock.Object.GetOwnerGroups();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Rows.Count);
            Assert.Equal("Owner Group 1", result.Rows[0]["Name"]);
        }

        [Fact]
        public async Task GetSqlDataInputTable_ShouldReturnValidDataTable()
        {
            // Arrange
            var mockDataTable = new DataTable();
            mockDataTable.Columns.Add("Id", typeof(int));
            mockDataTable.Columns.Add("InputName", typeof(string));
            mockDataTable.Rows.Add(1, "Data Input 1");
            mockDataTable.Rows.Add(2, "Data Input 2");

            _sqlServiceMock.Setup(s => s.GetSqlDataInputTable())
                           .ReturnsAsync(mockDataTable);

            // Act
            var result = await _sqlServiceMock.Object.GetSqlDataInputTable();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Rows.Count);
            Assert.Equal("Data Input 1", result.Rows[0]["InputName"]);
        }

        [Fact]
        public async Task GetSqlSheetInputTable_ShouldReturnValidDataTable()
        {
            // Arrange
            var mockDataTable = new DataTable();
            mockDataTable.Columns.Add("SheetName", typeof(string));
            mockDataTable.Columns.Add("StartRow", typeof(int));
            mockDataTable.Rows.Add("Sheet 1", 1);
            mockDataTable.Rows.Add("Sheet 2", 2);

            _sqlServiceMock.Setup(s => s.GetSqlSheetInputTable())
                           .ReturnsAsync(mockDataTable);

            // Act
            var result = await _sqlServiceMock.Object.GetSqlSheetInputTable();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Rows.Count);
            Assert.Equal("Sheet 1", result.Rows[0]["SheetName"]);
        }
    }
}