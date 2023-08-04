using Xunit;
using FluentAssertions;
using WorkerService1;

namespace DateHelperTests;

public class DateHelperTests
{

    [Fact]
    public void Should_ConvertDateFormat_Correctly()
    {
        // Arrange
        var inputDate = "2023-08-04T00:26:14.4599884Z";
        var timeZoneOffset = -6;
    
        // Act
        var result = DateHelper.ConvertDateFormat(inputDate, timeZoneOffset);
    
        // Assert
        result.Should().Be("2023-08-03T18:26-06:00");
    }



    [Theory]
    [InlineData("2023-08-04T00:26:14.4599884Z", "2023-08-03T18:26-06:00")]
    [InlineData("2022-12-31T13:45:30.1234567Z", "2022-12-31T07:45-06:00")]
    [InlineData("2021-01-01T00:00:00.0000000Z", "2020-12-31T18:00-06:00")]
    [InlineData("2024-02-29T23:59:59.9999999Z", "2024-02-29T17:59-06:00")]
    [InlineData("2025-06-15T12:30:45.6789123Z", "2025-06-15T06:30-06:00")]
    public void Should_ConvertDateFormat_CorrectlyWithInputs(string timeUtc, string timeAbb)
    {
        // Arrange
        var timeZoneOffset = -6;

        // Act
        var result = DateHelper.ConvertDateFormat(timeUtc, timeZoneOffset);

        // Assert
        result.Should().Be(timeAbb);
    }

}


