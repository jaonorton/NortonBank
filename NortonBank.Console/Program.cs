using NortonBank.CLI.Classes;
using System;
using System.Collections.Generic;

namespace NortonBank.CLI
{
    internal class Program
    {
        private static List<User> usuariosCadastrados = new List<User>();
        static void Main(string[] args)
        {
            bool pediuPraSair = false;
            do
            {
                MostrarIntroducao("BEM VINDO AO NORTON BANK");

                Console.WriteLine("Você é já possui conta no nosso serviço?");
                Console.WriteLine("Digite A para entrar");
                Console.WriteLine("Digite B para cadastrar");
                Console.WriteLine("Digite X para sair");

                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "A":
                    case "a":
                        AreaLogin();
                        break;
                    case "B":
                    case "b":
                        AreaCadastro();
                        break;
                    default:
                        pediuPraSair = true;
                        break;
                }
            } while (!pediuPraSair);

        }

        static void MostrarIntroducao(string mensagem)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("================================");
            Console.WriteLine($"====== {mensagem} ======");
            Console.WriteLine("================================");

            Console.ResetColor();
        }


        static void MenuDoUsuario(User usuario)
        {
            MostrarIntroducao($"Olá {usuario.Nome}!");   // pegar nome pelo cpf

            Console.WriteLine("\nSeu saldo é de x ");     // exibir saldo
            Console.WriteLine("\n\nO que deseja fazer?");
            Console.WriteLine("\n1 - Sacar");
            Console.WriteLine("\n2 - Depositar");
            Console.WriteLine("\n3 - Pagar conta");
            Console.WriteLine("\n4 - Extrato conta corrente");
            Console.WriteLine("\n5 - Extrato conta poupança");

            Console.WriteLine("Olá usuário, tudo bem? O que você quer?");

            Console.WriteLine("1 - Visualizar os restaurantes cadastrados");
            Console.WriteLine("2 - Buscar um item específico");
            Console.WriteLine("3 - Me cadastrar no sistema");
        }

        static void AreaLogin()
        {
            MostrarIntroducao("Seja bem vindo de volta!");

            Console.Write("\n\nPor favor, insira seu cpf -  ");
            string cpf = Console.ReadLine();

            // relizar verificação de cadastro

            // pedir senha se o usuário existir 

            User usuarioLogando = 
            // pegar perfil do usuario


            MenuDoUsuario(cpf);
        }
                

        static void AreaCadastro()
        {
            Console.WriteLine("Digite o cpf");
            string cpf = Console.ReadLine();
            // verificar se já existe cadastro

            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu email");
            string email = Console.ReadLine();

            Console.WriteLine("Digite uma senha");
            string senha = Console.ReadLine();

            User usuarioASerCadastrado = new User(cpf, nome, email, senha);
            usuariosCadastrados.Add(usuarioASerCadastrado);
            AreaLogin();
        }
                
            
    }

}

