﻿using FasTnT.Model.Enums;
using FasTnT.Model.Events;

namespace FasTnT.Data.PostgreSql.DTOs
{
    public class EpcDto : EventRelatedDto
    {
        public string Id { get; set; }
        public EpcType Type { get; set; }
        public bool IsQuantity { get; set; }
        public float? Quantity { get; set; }
        public string UnitOfMeasure { get; set; }

        internal Epc ToEpc()
        {
            return new Epc
            {
                Id = Id,
                Type = Type,
                IsQuantity = IsQuantity,
                Quantity = Quantity,
                UnitOfMeasure = UnitOfMeasure
            };
        }

        internal static EpcDto Create(Epc epc, short eventId, int requestId)
        {
            return new EpcDto
            {
                EventId = eventId,
                RequestId = requestId,
                Id = epc.Id,
                Type = epc.Type,
                IsQuantity = epc.IsQuantity,
                Quantity = epc.Quantity,
                UnitOfMeasure = epc.UnitOfMeasure
            };
        }
    }
}
