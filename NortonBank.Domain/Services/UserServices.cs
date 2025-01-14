using NortonBank.CLI.Models;
using NortonBank.Domain.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.Domain.Services        // aqui que ficam as regras de negócios
{
    public class UserServices
    {
        public void CadastrarUsuario(User usuarioASerCadastrado)
        {
            // Regras para cadastrar usuário
            UserDAO.Users.Add(usuarioASerCadastrado);
        }

        public List<User> ListarUsuarios()
        {
            return new List<User>();
        }

        public User GetUsuarioPorId(int id) {
            return new User("a", "a", "a", "a");
        }
        public User GetUsuarioPorEmail(string email) {
            return new User("a", "a", "a", "a");
        }
        public User GetUsuarioPorCpf(string cpf) {
            return new User("a", "a", "a", "a");
        }

        public void AtualizarCadastro(User usuarioASerAtualizado)
        {
            
        }
        public void RemoverUsuario(int id)
        {

        }
        
        public bool JaExisteCadastro(string cpf)    // retorna true se for cadastrado
        {
            return false;
        }
    }
}
