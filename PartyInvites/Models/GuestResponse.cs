﻿namespace PartyInvites.Models
{
    using System.ComponentModel.DataAnnotations;

    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your e-mail address")]
        [RegularExpression(".\\@\\..+", ErrorMessage = "Please enter a valid e-mail address ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}