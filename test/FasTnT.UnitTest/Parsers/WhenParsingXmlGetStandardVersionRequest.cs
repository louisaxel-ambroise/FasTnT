﻿using FasTnT.Commands.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FasTnT.UnitTest.Parsers
{
    [TestClass]
    public class WhenParsingXmlGetStandardVersionRequest : XmlParserTestBase
    {
        public override void Given()
        {
            SetRequest("<?xml version=\"1.0\" encoding=\"utf-8\"?><epcisq:EPCISQueryDocument xmlns:epcisq=\"urn:epcglobal:epcis-query:xsd:1\" creationDate=\"2019-01-26T20:10:01.8111457Z\" schemaVersion=\"1\"><EPCISBody><epcisq:GetStandardVersion /></EPCISBody></epcisq:EPCISQueryDocument>");
        }

        [TestMethod]
        public void ItShouldReturnAGetStandardVersionRequest()
        {
            Assert.IsInstanceOfType(Result, typeof(GetStandardVersionRequest));
        }
    }
}
