using System;
namespace Lab06.Models
{
    public class Employee
    {
        public string Fullname { get; set; }
        public byte Age { get; set; }
        public bool IsEmployee { get; set; }
        public Employee(string name, string surname, byte age)
        {
            this.Fullname = name + " " + surname;
            this.Age = age;
            IsEmployee = true;
        }
    }
}

