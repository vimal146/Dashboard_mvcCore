﻿using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
