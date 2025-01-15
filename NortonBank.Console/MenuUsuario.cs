using NortonBank.CLI.Models;
using NortonBank.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.CLI
{
    internal class MenuUsuario
    {
        static new UserServices _userServices = new UserServices();
        public static void AreaLogin()
        {
            Utilitarios.MostrarIntroducao("Seja bem vindo de volta!");

            Console.Write("\nPor favor, insira seu cpf: ");
            string cpf = Console.ReadLine();

            if (!_userServices.JaExisteCadastro(cpf))
            {
                Console.WriteLine("usuario não cadastrado");
                //voltar para a parte de criar
            }

            User usuarioLogando = _userServices.GetUsuarioPorCpf(cpf);

            MenuInicialDoUsuario(usuarioLogando);
        }

        public static void AreaCadastro()
        {
            Console.WriteLine("Digite o cpf");
            string cpf = Console.ReadLine();

            if (_userServices.JaExisteCadastro(cpf))
            {
                Console.WriteLine("\nUsuário já cadastrado, redirecionando para login");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nDigite o seu nome");
                string nome = Console.ReadLine();

                Console.WriteLine("\nDigite o seu email");
                string email = Console.ReadLine();

                Console.WriteLine("\nDigite uma senha");
                string senha = Console.ReadLine();

                User usuarioASerCadastrado = new User(cpf, nome, email, senha);
                _userServices.CadastrarUsuario(usuarioASerCadastrado);

                Console.WriteLine("Usuário cadastrado com sucesso, redirecionando para login");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadLine();
            }
            AreaLogin();
        }
        public static void MenuInicialDoUsuario(User usuario)
        {
            Utilitarios.MostrarIntroducao($"Olá {usuario.getName()}!");   // pegar nome pelo cpf

            Console.WriteLine("\nSeu saldo corrente é de x ");     // exibir saldo
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
    }
}
