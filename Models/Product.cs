﻿using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
    }
}
