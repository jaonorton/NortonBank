using NortonBank.CLI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.Domain.DAO
{
    public class UserDAO   // aqui fica a comunicação com o BD
    {
        public static List<User> Users = new List<User>();  //gambiarra para não mexer com bd agora
    }
}
