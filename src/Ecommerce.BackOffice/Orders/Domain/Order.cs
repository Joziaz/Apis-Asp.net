﻿using Ecommerce.Shared.Domain;
using Ecommerce.Shared.Domain.Enums;
using System.Collections.Generic;

namespace Ecommerce.BackOffice.Orders.Domain
{
    public class Order : BaseEntity
    {
        public float Total { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderDetail> Items { get; private set; }

        public void Complete()
        {
            Status = OrderStatus.Complete;
        }
    }
}