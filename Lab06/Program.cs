using System;
using System.Collections.Generic;
using Lab06.Database;
using Lab06.Models;
using Lab06.Services;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create operations
            Operations operations = new Operations();
            //Create an admin
            Admin admin = new Admin();
            //Create the database
            MyDatabase database = new MyDatabase();
            //Variables to store the matches
            bool usernameMatch = false;
            bool passwordMatch = false;
            //Store number of tries
            byte tries = 0;
            //Loop to get the correct username and password
            do
            {
                if (tries >= 3)
                {
                    Console.WriteLine("You have made 3 tries already!!!");
                    return;
                }
                Console.Write("Enter the username: ");
                string username = Console.ReadLine();
                Console.Write("Enter the password: ");
                string password = Console.ReadLine();
                tries++;
                if(username == admin.Username && password == admin.Password)
                {
                    usernameMatch = true;
                    passwordMatch = true;
                    break;
                }
            }
            while (!usernameMatch || !passwordMatch);
            
            //Create employee List
            List<Employee> employees = new List<Employee>();
            
            //Get each employee
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Employee{i + 1}'s name: ");
                string name = Console.ReadLine();
                Console.Write($"Employee {i + 1}'s surname: ");
                string surname = Console.ReadLine();
                Console.Write($"Employee {i + 1}'s age: ");
                Console.WriteLine(" ");
                byte age = byte.Parse(Console.ReadLine());
                employees.Add(operations.CreateEmployee(name, surname, age));
            }
            //Add to the database list
            database.employees = employees;
            //Create a department
            operations.CreateDepartment("IT", employees);
            //Delete
            operations.DeleteEmployee(employees[1].Fullname, database);
            //Get employees
            operations.GetActiveEmployees(database);
            operations.GetAllEmployees(database);

        }
    }
}

