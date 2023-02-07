﻿using System.ComponentModel.DataAnnotations;

namespace MasterDetailAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
