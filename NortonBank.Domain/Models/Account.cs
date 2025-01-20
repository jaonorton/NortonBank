using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.Domain.Models
{
    public abstract class Account
    {
        private int Agencia;
        private int Numero;
        private int IdTitular;

        protected double Saldo;     // essa classe e filhos tem acesso

        public void Depoistar(decimal depoistar)
        {
            
        }
        public void Sacar(decimal saque)
        {
            
        }
    }
}
