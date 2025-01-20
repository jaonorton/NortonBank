using NortonBank.CLI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.Domain.DAO
{
    // internal = só aquele programa tem acesso (NortonBank.Domain)
    // é assim pq só quem pode acessar o DAO são os services
    internal class UserDAO   // aqui fica a comunicação com o BD
    {
        public static List<User> Users = new List<User>();  //gambiarra para não mexer com bd agora
        
    }
}
