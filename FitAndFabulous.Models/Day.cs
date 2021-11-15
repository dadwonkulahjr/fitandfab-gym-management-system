﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FitAndFabulous.Models
{
    public class Day
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
