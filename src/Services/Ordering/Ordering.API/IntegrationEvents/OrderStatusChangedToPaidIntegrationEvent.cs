﻿namespace Microsoft.eShopOnContainers.Services.Ordering.API.IntegrationEvents
{
    using System;
    using System.Collections.Generic;
    using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;

    public class OrderStatusChangedToPaidIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }
        public string OrderStatus { get; set; }
        public string Description { get; set; }
        public IEnumerable<OrderStockItem> OrderStockItems { get; set; }
        public string BuyerId { get; set; }

        public OrderStatusChangedToPaidIntegrationEvent()
        {
        }

        public OrderStatusChangedToPaidIntegrationEvent(Guid orderId, string orderStatus,
            string description, IEnumerable<OrderStockItem> orderStockItems, string buyerId)
        {
            OrderId = orderId;
            Description = description;
            OrderStatus = orderStatus;
            OrderStockItems = orderStockItems;
            BuyerId = buyerId;
        }
    }
}
