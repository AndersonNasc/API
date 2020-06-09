
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UnitTestApi.Fixture;
using Xunit;

namespace UnitTestApi.Scenario
{
    public class ClientAPI_Test
    {
        private readonly TestContext _testContext;

        public ClientAPI_Test()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task Get()
        {
            var response = await _testContext.Client.GetAsync("/api/Clients");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Post()
        {
            var formData = new Dictionary<string, string>
            {
                {"name", "Joe smith"},
                {"age", "40"}
            };

            await _testContext.Client.PostAsync("/api/Clients",new FormUrlEncodedContent(formData));
        }

        [Fact]
        public async Task Put()
        {
            var formData = new Dictionary<string, string>
            {
                {"Id", "_85A0763D-F857-469F-A2A9-A6B97C87A611" },
                {"name", "Joe smith"},
                {"age", "40"}
            };

            await _testContext.Client.PutAsync("/api/Clients", new FormUrlEncodedContent(formData));
        }

        [Fact]
        public async Task Delete()
        {  
            await _testContext.Client.DeleteAsync("/api/Clients");
        }
    }
}
