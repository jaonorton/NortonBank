using NortonBank.CLI.Models;
using NortonBank.Domain.Services;
using System;
using System.Collections.Generic;

namespace NortonBank.CLI
{
    internal class Program
    {
        static new UserServices _userServices = new UserServices();
        static void Main(string[] args)
        {
            bool pediuPraSair = false;
            do
            {
                Utilitarios.MostrarIntroducao("BEM VINDO AO NORTON BANK");

                Console.WriteLine("Você é já possui conta no nosso serviço?");
                Console.WriteLine("Digite A para entrar");
                Console.WriteLine("Digite B para cadastrar");
                Console.WriteLine("Digite X para sair");

                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "A":
                    case "a":
                        MenuUsuario.AreaLogin();
                        break;
                    case "B":
                    case "b":
                        MenuUsuario.AreaCadastro();
                        break;
                    default:
                        pediuPraSair = true;
                        break;
                }
            } while (!pediuPraSair);

        }
        
    }

}

