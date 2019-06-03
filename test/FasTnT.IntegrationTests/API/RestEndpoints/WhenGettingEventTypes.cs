﻿using fastJSON;
using FasTnT.IntegrationTests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace FasTnT.IntegrationTests.API.RestEndpoints
{
    [TestClass]
    [TestCategory("IntegrationTests")]
    public class WhenGettingEventTypes : BaseMigratedIntegrationTest
    {
        public override void Act()
        {
            Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", "YWRtaW46UEBzc3cwcmQ=");
            Result = Client.GetAsync("/v1.2/events").Result;
        }

        [Assert]
        public void ItShouldReturnHttp200OK() => Assert.AreEqual(HttpStatusCode.OK, Result.StatusCode);

        [Assert]
        public void ItShouldReturnAnArrayOfString() => Assert.IsNotNull(JSON.ToObject<string[]>(Result.Content.ReadAsStringAsync().Result));

        [Assert]
        public void ItShouldReturnAllExistingEventTypes() => CollectionAssert.AreEquivalent(new[] { "ObjectEvent", "AggregationEvent", "TransactionEvent", "TransformationEvent", "QuantityEvent" }, JSON.ToObject<string[]>(Result.Content.ReadAsStringAsync().Result));
    }
}