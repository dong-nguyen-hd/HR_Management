﻿using HR_Management.Extensions.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace HR_Management.Resources.WorkHistory
{
    public class UpdateWorkHistoryResource
    {
        [Required]
        [MaxLength(250)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Position { get; set; }

        [Required]
        [StartDate("EndDate")]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
    }
}
