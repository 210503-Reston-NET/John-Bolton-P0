﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int LocationId { get; set; }
        public int CustomerId { get; set; }
        public double Total { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
