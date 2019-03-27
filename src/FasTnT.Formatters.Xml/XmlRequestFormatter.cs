﻿using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using FasTnT.Formatters.Xml.Requests;
using FasTnT.Formatters.Xml.Responses;
using FasTnT.Formatters.Xml.Validation;
using FasTnT.Model;
using FasTnT.Model.Events.Enums;

namespace FasTnT.Formatters.Xml
{
    public class XmlRequestFormatter : IRequestFormatter
    {
        public Request Read(Stream input)
        {
            var document = XmlDocumentParser.Instance.Load(input);

            if (document.Root.Name == XName.Get("EPCISDocument", EpcisNamespaces.Capture))
            {
                return new EpcisEventDocument
                {
                    Header = ParseHeader(document.Root),
                    EventList = XmlEventsParser.ParseEvents(document.Root.XPathSelectElement("EPCISBody/EventList").Elements().ToArray())
                };
            }
            else if (document.Root.Name == XName.Get("EPCISQueryDocument", EpcisNamespaces.Query)) // Subscription result
            {
                return ParseCallback(document);
            }
            else if (document.Root.Name == XName.Get("EPCISMasterDataDocument", EpcisNamespaces.MasterData))
            {
                return new EpcisMasterdataDocument
                {
                    Header = ParseHeader(document.Root),
                    MasterDataList = XmlMasterDataParser.ParseMasterDatas(document.Root.Element("EPCISBody").Element("VocabularyList").Elements("Vocabulary"))
                };
            }

            throw new Exception($"Document with root '{document.Root.Name.ToString()}' is not expected here.");
        }

        private Request ParseCallback(XDocument document)
        {
            switch (document.Root.Element("EPCISBody").Elements().First().Name.LocalName)
            {
                case "QueryTooLargeException":
                    return new EpcisQueryCallbackException
                    {
                        Header = ParseHeader(document.Root),
                        SubscriptionName = document.Root.Element("EPCISBody").Element(XName.Get("QueryTooLargeException", EpcisNamespaces.Query)).Element("subscriptionID").Value,
                        Reason = document.Root.Element("EPCISBody").Element(XName.Get("QueryTooLargeException", EpcisNamespaces.Query)).Element("reason").Value,
                        CallbackType = QueryCallbackType.ImplementationException
                    };
                case "ImplementationException":
                    return new EpcisQueryCallbackException
                    {
                        Header = ParseHeader(document.Root),
                        SubscriptionName = document.Root.Element("EPCISBody").Element(XName.Get("ImplementationException", EpcisNamespaces.Query)).Element("subscriptionID").Value,
                        Reason = document.Root.Element("EPCISBody").Element(XName.Get("ImplementationException", EpcisNamespaces.Query)).Element("reason").Value,
                        CallbackType = QueryCallbackType.ImplementationException
                    };
                case "QueryResults":
                    return new EpcisQueryCallbackDocument
                    {
                        Header = ParseHeader(document.Root),
                        SubscriptionName = document.Root.Element("EPCISBody").Element(XName.Get("QueryResults", EpcisNamespaces.Query)).Element("subscriptionID").Value,
                        EventList = XmlEventsParser.ParseEvents(document.Root.Element("EPCISBody").Element(XName.Get("QueryResults", EpcisNamespaces.Query)).Element("resultsBody").Element("EventList").Elements().ToArray())
                    };
            }

            throw new Exception($"Document with root '{document.Root.Name.ToString()}' is not expected here.");
        }

        private EpcisRequestHeader ParseHeader(XElement root)
        {
            return new EpcisRequestHeader
            {
                DocumentTime = DateTime.Parse(root.Attribute("creationDate").Value, CultureInfo.InvariantCulture),
                SchemaVersion = root.Attribute("schemaVersion").Value
            };
        }

        public void Write(Request entity, Stream output)
        {
            XDocument document = Write((dynamic)entity);
            var bytes = Encoding.UTF8.GetBytes(document.ToString(SaveOptions.DisableFormatting | SaveOptions.OmitDuplicateNamespaces));

            output.Write(bytes, 0, bytes.Length);
        }

        private XDocument Write(EpcisEventDocument entity)
        {
            return new XDocument(
                XName.Get("EPCISDocument", EpcisNamespaces.Capture),
                new XAttribute("creationDate", entity.Header.DocumentTime.ToString("yyyy-MM-ddThh:MM:ssZ")),
                new XAttribute("schemaVersion", entity.Header.SchemaVersion),
                new XElement("EPCISBody", new XElement("EventList", entity.EventList.Select(new XmlEventFormatter().Format)))
            );
        }
    }
}
