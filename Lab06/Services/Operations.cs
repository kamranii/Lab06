using System;
using Lab06.Models;
using Lab06.Database;
using System.Collections.Generic;
using System.Linq;

namespace Lab06.Services
{
    public class Operations: IOperations
    {
        public Employee CreateEmployee(string name, string surname, byte age)
        {
            Employee employee = new Employee(name, surname, age);
            return employee;
        }
        public void CreateDepartment(string name, List<Employee> employees)
        {
            Department department = new Department(name);
            department.employees = employees;
            
        }
        public void DeleteEmployee(string fullname, MyDatabase database)
        {
            Employee employee = database.employees.Where(x => x.Fullname == fullname).FirstOrDefault();
            if(employee.Equals(null))
            {
                Console.WriteLine("Employee not found");
                return;
            }
            employee.IsEmployee = false;
        }
        public void GetActiveEmployees(MyDatabase database)
        {
            List<Employee> activeEmployees = database.employees.Where(m => m.IsEmployee == true).ToList();
            Console.WriteLine(" ");
            Console.WriteLine("Active employees are: ");
            foreach(Employee employee in activeEmployees)
            {
                Console.WriteLine($"{employee.Fullname}");
            }
            
        }
        public void GetAllEmployees(MyDatabase database)
        {
            Console.WriteLine(" ");
            Console.WriteLine("All employees are: ");
            foreach(Employee employee in database.employees)
            {
                Console.WriteLine($"{employee.Fullname}");
            }
        }

        public Operations()
        {
        }
    }
}

