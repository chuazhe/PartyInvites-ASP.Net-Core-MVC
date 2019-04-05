﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")] //Property Level
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")] //Property Level
        [RegularExpression(".+\\@.+\\..+",
 ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")] //Property Level
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")] //Property Level
        public bool? WillAttend { get; set; }
    }
}
