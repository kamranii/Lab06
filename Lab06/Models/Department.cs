using System;
using System.Collections.Generic;

namespace Lab06.Models
{
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> employees = new List<Employee>();
        public Department(string name)
        {
            Name = name;
        }
    }
}

