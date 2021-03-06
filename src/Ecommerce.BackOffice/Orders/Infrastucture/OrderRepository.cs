﻿using Ecommerce.BackOffice.Orders.Domain;
using Ecommerce.Shared.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.BackOffice.Orders.Infrastucture
{
    public class OrderRepository : CRUDRepository<Order>
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }
    }
}
