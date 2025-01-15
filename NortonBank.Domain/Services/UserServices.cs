using NortonBank.CLI.Models;
using NortonBank.Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return UserDAO.Users;
        }

        public User GetUsuarioPorId(int id) {
            return UserDAO.Users.Where(item => item.getId() == id).First();
        }
        public User GetUsuarioPorEmail(string email) {
            return UserDAO.Users.Where(item => item.getEmail() == email).First();
        }
        public User GetUsuarioPorCpf(string cpf){
            return UserDAO.Users.Where(item => item.getCpf() == cpf).First();
        }

        public void AtualizarNome(int idUsuarioASerAtualizado, string novoNome)
        {
            User usuarioASerAtualizado = GetUsuarioPorId(idUsuarioASerAtualizado);
            usuarioASerAtualizado.setName(novoNome);
        }
        public void RemoverUsuario(int idUsuarioASerRemovido)
        {
            UserDAO.Users.Remove(GetUsuarioPorId(idUsuarioASerRemovido));
        }
        
        public bool JaExisteCadastro(string cpf)    // retorna true se for cadastrado
        {
            User usuarioASerEncontrado = UserDAO.Users.Where(x => x.getCpf() == cpf).First();
            return UserDAO.Users.Contains(usuarioASerEncontrado);
        }
    }
}
