using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.CLI.Models
{
    public class User
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public User() { }

        public User(string cpf, string name, string email, string password)
        {
            this.Cpf = cpf;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }
    }
}
