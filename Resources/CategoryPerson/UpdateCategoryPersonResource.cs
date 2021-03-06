﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HR_Management.Resources.CategoryPerson
{
    public class UpdateCategoryPersonResource
    {
        [Required]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public List<int> Technology { get; set; }
    }
}
