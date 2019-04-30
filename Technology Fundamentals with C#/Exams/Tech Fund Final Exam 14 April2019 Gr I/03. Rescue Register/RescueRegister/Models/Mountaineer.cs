﻿namespace RescueRegister.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Mountaineer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime LastSeenDate { get; set; }

    }
}
