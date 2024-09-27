using System.Data;
using Xunit;
using Moq;
using DataPaintLibrary.Services.Interfaces;

namespace DataPaintLibraryTests.Services.Interfaces
{
    public class DataExtractionServiceTests
    {
        [Fact]
        public void GetExcelDataSet_ValidFilePath_ReturnsDataSet()
        {
            // Arrange
            var mockDataExtractionService = new Mock<IDataExtractionService>();
            var expectedDataSet = new DataSet();
            string testFilePath = "test.xlsx";

            // Mocking the GetExcelDataSet method to return a DataSet when called
            mockDataExtractionService
                .Setup(service => service.GetExcelDataSet(It.IsAny<string>()))
                .Returns(expectedDataSet);

            // Act
            var actualDataSet = mockDataExtractionService.Object.GetExcelDataSet(testFilePath);

            // Assert
            Assert.NotNull(actualDataSet); // Check that a DataSet is returned
            Assert.Equal(expectedDataSet, actualDataSet); // Check that the returned DataSet matches the expected one
            mockDataExtractionService.Verify(service => service.GetExcelDataSet(testFilePath), Times.Once); // Ensure the method was called once with the correct file path
        }
    }
}