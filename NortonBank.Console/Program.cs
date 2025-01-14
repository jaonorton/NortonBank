using NortonBank.CLI.Models;
using NortonBank.Domain.Services;
using System;
using System.Collections.Generic;

namespace NortonBank.CLI
{
    internal class Program
    {
        static new UserServices userServices = new UserServices();
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
            Console.WriteLine($"===== {mensagem} =====");
            Console.WriteLine("================================");

            Console.ResetColor();
        }
        static void MenuDoUsuario(User usuario){
            MostrarIntroducao($"Olá {usuario.getName()}!");   // pegar nome pelo cpf

            Console.WriteLine("\nSeu saldo é de x ");     // exibir saldo
            Console.WriteLine("\n\nO que deseja fazer?");
            Console.WriteLine("A - Sacar");
            Console.WriteLine("B - Depositar");
            Console.WriteLine("C - Pagar conta");
            Console.WriteLine("D - Extrato conta corrente");
            Console.WriteLine("E - Extrato conta poupança");

            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "A":
                case "a":
                    
                    break;
                case "B":
                case "b":
                    
                    break;
                case "C":
                case "c":
                    
                    break;
                case "D":
                case "d":
                    
                    break;
                case "E":
                case "e":
                    
                    break;
                default:
                    
                    break;
            }

        }

        static void AreaLogin()
        {
            MostrarIntroducao("Seja bem vindo de volta!");

            Console.Write("\nPor favor, insira seu cpf: ");
            string cpf = Console.ReadLine();

            if (!userServices.JaExisteCadastro(cpf))     
            {
                Console.WriteLine("usuario não cadastrado");
                //voltar para a parte de login
            } 

            User usuarioLogando = userServices.GetUsuarioPorCpf(cpf);

            MenuDoUsuario(usuarioLogando);
        }
                
        static void AreaCadastro()
        {
            Console.WriteLine("Digite o cpf");
            string cpf = Console.ReadLine();

            // verificar se já existe cadastro
                // sim: jogar para loguin
                // não: continuar

                      
            
       
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu email");
            string email = Console.ReadLine();

            Console.WriteLine("Digite uma senha");
            string senha = Console.ReadLine();

            User usuarioASerCadastrado = new User(cpf, nome, email, senha);
            userServices.CadastrarUsuario(usuarioASerCadastrado);
            AreaLogin();
        }
                
            
    }

}

