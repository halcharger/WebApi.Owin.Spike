using System;
using System.Net.Http;
using FluentAssertions;
using Microsoft.Owin.Hosting;
using Microsoft.Owin.Testing;
using NUnit.Framework;
using WebApi.Owin.AppHost;

namespace Tests
{
    [TestFixture]
    public class HostingTests
    {
        [Test]
        public void FullWebServerTest()
        {
            var baseUrl = "http://localhost:9998"; 
            using (WebApp.Start<Startup>(baseUrl))
            {
                // Create HttpCient and make a request to api/values 
                var client = new HttpClient();

                var response = client.GetAsync(baseUrl + "/api/test").Result;

                Console.WriteLine(response);
                var result = response.Content.ReadAsStringAsync().Result;
                result.Should().Be("[\"string1\",\"string2\"]");
            }
        }

        [Test]
        public void InMemoryTest()
        {
            using (var server = TestServer.Create<Startup>())
            {
                var response = server.HttpClient.GetAsync("/api/test").Result;

                Console.WriteLine(response);
                var result = response.Content.ReadAsStringAsync().Result;
                result.Should().Be("[\"string1\",\"string2\"]");
            }
        }
    }
}
