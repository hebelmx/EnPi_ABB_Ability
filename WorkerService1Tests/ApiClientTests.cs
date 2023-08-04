using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkerService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using Moq;
using FluentAssertions;
using System.Net.Http;
using System.Threading.Tasks;
using System;

public class ApiClientTests
{
    [Fact]
    public async Task SendRequest_Should_Return_Successful_Response()
    {
        // Arrange
        var mockHttpClient = new Mock<HttpClient>();
        var apiParameters = new ApiParameters
        {
            ApplicationId = "55420070-03fb-4b4f-bf84-23ffc20625ff",
            PlantId = "cde0ea28-70d7-424e-8064-271f96c3a2c5",
            ApiKey = "TSVPNQaT4s78hs8ZsO7NxXeGst77mlgGVw==",
            SubscriptionKey = "9ab2f67bb5b3425baf7896105d09949d"
        };

        var apiClient = new ApiClient(mockHttpClient.Object, apiParameters);

        var postData = new PostData
        {
            ParameterName = "oee",
            Date = DateTime.UtcNow,
            Value = 47
        };

        // Act
        Func<Task> act = async () => { await apiClient.SendRequest(postData); };

        // Assert
       // act.Should().
    }
}
