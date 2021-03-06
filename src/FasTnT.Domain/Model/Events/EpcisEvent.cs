﻿using FasTnT.Model.Enums;
using System;
using System.Collections.Generic;

namespace FasTnT.Model.Events
{
    public class EpcisEvent
    {
        public DateTime CaptureTime { get; set; }
        public DateTime EventTime { get; set; }
        public TimeZoneOffset EventTimeZoneOffset { get; set; } = TimeZoneOffset.Default;
        public EventType Type { get; set; }
        public EventAction Action { get; set; }
        public string EventId { get; set; }
        public string ReadPoint { get; set; }
        public string BusinessLocation { get; set; }
        public string BusinessStep { get; set; }
        public string Disposition { get; set; }
        public string TransformationId { get; set; }
        public DateTime? CorrectiveDeclarationTime { get; set; }
        public string CorrectiveReason { get; set; }
        public List<string> CorrectiveEventIds { get; set; } = new List<string>();
        public List<Epc> Epcs { get; set; } = new List<Epc>();
        public List<BusinessTransaction> BusinessTransactions { get; set; } = new List<BusinessTransaction>();
        public List<SourceDestination> SourceDestinationList { get; set; } = new List<SourceDestination>();
        public List<CustomField> CustomFields { get; set; } = new List<CustomField>();
    }
}
