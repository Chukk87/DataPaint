using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using DataPaintLibrary.Classes;
using DataPaintLibrary.Services.Interfaces;

namespace DataPaintLibraryTests.Services.Interfaces
{
    public class LoggerServiceTests
    {
        private readonly Mock<ILoggerService> mockLoggerService;

        public LoggerServiceTests()
        {
            mockLoggerService = new Mock<ILoggerService>();
        }

        [Theory]
        [InlineData("Test exception", "TestMethod", "Some extra detail", true)]
        [InlineData("Test exception", "TestMethod", null, false)]
        public void RecordException_LogsException(string exceptionMessage, string method, string otherDetail, bool hasExtraDetail)
        {
            // Arrange
            var exception = new Exception(exceptionMessage);

            // Act
            if (hasExtraDetail)
            {
                mockLoggerService.Object.RecordException(exception, method, otherDetail);
            }
            else
            {
                mockLoggerService.Object.RecordException(exception, method);
            }

            // Assert
            if (hasExtraDetail)
            {
                mockLoggerService.Verify(service => service.RecordException(exception, method, otherDetail), Times.Once);
            }
            else
            {
                mockLoggerService.Verify(service => service.RecordException(exception, method), Times.Once);
            }
        }

        [Fact]
        public void LogInfo_LogsInfoMessage()
        {
            // Arrange
            string message = "This is an info message";
            string method = "TestMethod";

            // Act
            mockLoggerService.Object.LogInfo(message, method);

            // Assert
            mockLoggerService.Verify(service => service.LogInfo(message, method), Times.Once);
        }

        [Fact]
        public void GetLogs_ReturnsListOfLogs()
        {
            // Arrange
            var logs = new List<Log>
            {
                new Log { OtherDetail = "Log 1", MethodSource = "Method1", Timestamp = DateTime.Now },
                new Log { OtherDetail = "Log 2", MethodSource = "Method2", Timestamp = DateTime.Now }
            };

            // Mock the GetLogs method to return a list of logs
            mockLoggerService
                .Setup(service => service.GetLogs())
                .Returns(logs);

            // Act
            var result = mockLoggerService.Object.GetLogs();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, logs.Count);
            Assert.Equal(logs, result);
        }
    }
}
