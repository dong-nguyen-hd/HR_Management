﻿using System.ComponentModel.DataAnnotations;

namespace HR_Management.Resources.Technology
{
    public class CreateTechnologyResource
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
    }
}
