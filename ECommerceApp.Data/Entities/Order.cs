﻿using ECommerceApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Data.Entities
{
    public class Order : BaseEntity
    {
        public Status OrderStatus { get; set; } = Status.Pending;
        public DateTime OrderedDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public int? PaymentId { get; set; }
        public Payment? Payment { get; set; }
        [Required]
        public string UserId { get; set; }
        public AppUser User { get; set; }   
        public ICollection<OrderItem> OrderItems { get; set; }
    }

}



