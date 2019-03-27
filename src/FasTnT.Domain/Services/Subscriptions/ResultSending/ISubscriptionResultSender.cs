﻿using FasTnT.Model.Responses;
using System.Threading.Tasks;

namespace FasTnT.Domain.Services.Subscriptions
{
    public interface ISubscriptionResultSender
    {
        Task Send(string destination, IEpcisResponse response, string contentType = "application/xml");
    }
}
