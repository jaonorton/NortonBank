using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.CLI.Models
{
    public class User
    {
        private string Cpf { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private int Id { get; set; }
        private User() { }

        public User(string cpf, string name, string email, string password)
        {
            this.Cpf = cpf;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public void setCpf(string cpf) {this.Cpf = cpf;}
        public string getCpf() {return this.Cpf;}

        public void setName(string name) {this.Name = name;}
        public string getName() {return this.Name;}

        public void setEmail(string email) {this.Name = email;}
        public string getEmail() {return this.Name;}

        public void setId(int id) {this.Id = id;}
        public int getId() {return this.Id;}

    }
}
