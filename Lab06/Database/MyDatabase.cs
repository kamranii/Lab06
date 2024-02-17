using System;
using System.Collections.Generic;
using Lab06.Models;

namespace Lab06.Database
{
    public class MyDatabase
    {
        public List<Department> departments;
        public List<Employee> employees;
        public MyDatabase()
        {
            this.departments = new List<Department>();
            this.employees = new List<Employee>();
        }
    }
}

