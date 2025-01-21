using NortonBank.CLI.Models;
using NortonBank.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NortonBank.Domain.Test.Unit.Services
{
    public class UsuarioServiceTest     // rodar 
    {
        private UserServices _userServices = new UserServices();
        User _userTester = new User();

        [Fact(DisplayName="Deve verificar se o usuário é maior de idade")]  //isso é um fato
        public void DeveVerificarSeEhMaiorIdade()       //começa com deve ou should 
        {
            // preparação
            _userTester.Age = 18;

            // ação a ser testada
            bool resultado = _userServices.VerificarMaioridade(_userTester);

            //  checagem de fatos
            Assert.True(resultado);

            // aqui eu repito um teste para testar o > (coisa da minha cabeça)
            _userTester.Age = 19;

            resultado = _userServices.VerificarMaioridade(_userTester);

            Assert.True(resultado);
        }

        [Fact(DisplayName = "Deve verificar se o usuário é menor de idade")]  //isso é um fato
        public void DeveVerificarSeEhMenorIdade()       //começa com deve ou should 
        {
            // preparação
            _userTester.Age = 17;

            // ação a ser testada
            bool resultado = _userServices.VerificarMaioridade(_userTester);

            //  checagem de fatos
            Assert.False(resultado);

            _userTester.Age = 0;

            resultado = _userServices.VerificarMaioridade(_userTester);

            Assert.False(resultado);
        }

        // Teoria
        [Theory(DisplayName = "Verificação de idade do usuário só pode permitir maiores de 18")]
        [InlineData(20, true)]         // Testes
        [InlineData(18, true)]         // Basicamente vai testar tudo a cima usando somente um método
        [InlineData(17, false)]
        [InlineData(-1, false)]
        public void DeveVerificarAMaiorIdade(int idadeASerTestada, bool resultadoEsperado)
        {
            // preparação
            _userTester.Age = idadeASerTestada;

            // ação a ser testada
            bool resultado = _userServices.VerificarMaioridade(_userTester);

            //  checagem de fatos
            Assert.True(resultado == resultadoEsperado);
        }
    }
}
