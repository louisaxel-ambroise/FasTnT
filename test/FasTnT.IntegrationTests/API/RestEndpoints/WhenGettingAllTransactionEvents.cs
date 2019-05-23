﻿using fastJSON;
using FasTnT.IntegrationTests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Text;

namespace FasTnT.IntegrationTests.API.RestEndpoints
{
    [TestClass]
    [TestCategory("IntegrationTests")]
    public class WhenGettingAllTransactionEvents : BaseMigratedIntegrationTest
    {
        public override void Act()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/v1.2/events/TransactionEvent/all") { Content = new StringContent("", Encoding.UTF8, "application/json") };
            Result = Client.SendAsync(request).Result;
        }

        [Assert]
        public void ItShouldReturnHttp200OK() => Assert.AreEqual(HttpStatusCode.OK, Result.StatusCode);

        [Assert]
        public void ItShouldReturnAnArrayOfString() => Assert.IsNotNull(JSON.ToObject<object[]>(Result.Content.ReadAsStringAsync().Result));
    }
}