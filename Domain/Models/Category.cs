﻿using System.Collections.Generic;

namespace HR_Management.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public CategoryPerson CategoryPerson { get; set; }
        public ICollection<Technology> Technologies { get; set; }
    }
}
