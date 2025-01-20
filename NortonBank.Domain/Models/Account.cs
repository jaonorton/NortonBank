using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.Domain.Models
{
    public abstract class Account
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public int IdTitular { get; set; }

        protected double Saldo;     // essa classe e filhos tem acesso

        public void Depoistar(decimal depoistar)
        {
            
        }
        public void Sacar(decimal saque)
        {
            
        }
    }
}
