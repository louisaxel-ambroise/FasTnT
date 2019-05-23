﻿using fastJSON;
using FasTnT.IntegrationTests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace FasTnT.IntegrationTests.API.RestEndpoints
{
    [TestClass]
    [TestCategory("IntegrationTests")]
    public class WhenGettingQueryNames : BaseMigratedIntegrationTest
    {
        public override void Act()
        {
            Result = Client.GetAsync("/v1.2/queries").Result;
        }

        [Assert]
        public void ItShouldReturnHttp200OK() => Assert.AreEqual(HttpStatusCode.OK, Result.StatusCode);

        [Assert]
        public void ItShouldReturnAnArrayOfString() => Assert.IsNotNull(JSON.ToObject<string[]>(Result.Content.ReadAsStringAsync().Result));

        [Assert]
        public void ItShouldReturnAllExistingQueryNames() => CollectionAssert.AreEquivalent(new[] { "SimpleEventQuery", "SimpleMasterDataQuery" }, JSON.ToObject<string[]>(Result.Content.ReadAsStringAsync().Result));
    }
}