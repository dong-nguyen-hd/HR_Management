﻿using HR_Management.Extensions.Validation;
using System.ComponentModel.DataAnnotations;

namespace HR_Management.Resources.Account
{
    public class UpdateAccountResource
    {
        [Required]
        [Password]
        public string Password { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(500)]
        public string Email { get; set; }

        [Required]
        [Role]
        public int Role { get; set; }
    }
}
