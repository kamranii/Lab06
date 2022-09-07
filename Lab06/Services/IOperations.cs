using System;
using System.Collections.Generic;
using Lab06.Database;
using Lab06.Models;

namespace Lab06.Services
{
    public interface IOperations
    {
        public Employee CreateEmployee(string name, string surname, byte age);
        public void CreateDepartment(string name, List<Employee> employees);
        public void DeleteEmployee(string fullname, MyDatabase database);
        public void GetActiveEmployees(MyDatabase database);
        public void GetAllEmployees(MyDatabase database);
    }
}

