using System;
namespace Lab06.Models
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Admin()
        {
            Username = "admin123";
            Password = "1234";
        }
    }
}

