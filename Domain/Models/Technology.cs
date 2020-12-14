﻿namespace HR_Management.Domain.Models
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
