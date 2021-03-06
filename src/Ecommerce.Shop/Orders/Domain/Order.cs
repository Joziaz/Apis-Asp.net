﻿using Ecommerce.Shared.Domain;
using Ecommerce.Shared.Domain.Enums;
using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shop.Products.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Shop.Orders.Domain
{
    public class Order : BaseEntity
    {
        public decimal Total { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderDetail> Items { get; private set; }

        public void CalculateTotal()
        {
            decimal value = 0m;
            Items.ForEach(item => value += item.Total);
            Total = value;
        }

        public void AddItem(Product product, uint quantity)
        {
            var item = Items.FirstOrDefault(item => item.Product == product);
            if (item == null)
            {
                OrderDetail newItem = new OrderDetail(this, product, quantity);
                Items.Add(newItem);
            }
            else
                item.AddQuantity(quantity);
        }

        public void RemoveItem(Product product)
        {
            OrderDetail item = Items.FirstOrDefault(item => item.Product == product);
            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the order");
            else
                Items.Remove(item);
        }
    }
}
