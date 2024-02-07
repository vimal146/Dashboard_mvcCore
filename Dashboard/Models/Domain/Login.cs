﻿using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Domain
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemember { get; set; }
    }
}
