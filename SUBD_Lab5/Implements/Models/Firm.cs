﻿using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Firm
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
