using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.CLI.Classes
{
    public class User
    {
        private string Cpf {  get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private User() { }

        public User(string cpf, string name, string email, string password)
        {
            this.Cpf = cpf;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }
    }
}
