using TecnPoint.Dados;
using TecnPoint.Modelo;
using TecnPoint.Service;
using Moq;

namespace TecnPointTestes
{
    public class TesteLoginUsuario
    {
        [Fact]  
        public void LoginUsuario_DeveRetornarUsuarioCorreto_QuandoEmailSenhaForemValidos()
        {
            var mockDados = new Mock<IDadosUsuario>();

            //criando usuário que será retornado quando seu e-mail e senha forem digitados corretamente no login
            ModeloUsuario usuarioCadastrado = new ModeloUsuario
            {
                IdUsuario = 1,
                Nome = "TesteCliente",
                Email = "teste@gmail.com",
                Senha = "teste123",
                TipoUsuario = "Cliente"
            };

            //configurando mock "Se chamarem  o método LoginUsuario com esse e-mail e com essa senha, retorna o usuário com esse e-mail e com essa senha"
            mockDados.Setup(repo => repo.LoginUsuario("teste@gmail.com", "teste123"))
                .Returns(usuarioCadastrado);

            var servLogin = mockDados.Object;

            ModeloUsuario resultadoConsulta = servLogin.LoginUsuario("teste@gmail.com", "teste123");

            Assert.NotNull(resultadoConsulta);
            Assert.Equal("teste@gmail.com", resultadoConsulta.Email);
            Assert.Equal("TesteCliente", resultadoConsulta.Nome);
            Assert.Equal("Cliente", resultadoConsulta.TipoUsuario);
        }

        [Fact]
        public void LoginUsuario_DeveRetornarNull_SeUsuarionaoExistirNoBancoDeDados()
        {
            var mockDados = new Mock<IDadosUsuario>();

            //"Se usarem o método LoginUsuario com esse e-mail e essa senha (de um usuário que não existe), retorna null"
            mockDados.Setup(repo => repo.LoginUsuario("emailtestenulo@gmail.com", "senhanaoexiste"))
                .Returns((ModeloUsuario)null);

            var servLogin = mockDados.Object;

            ModeloUsuario resultadoConsulta = servLogin.LoginUsuario("emailtestenulo@gmail.com", "senhanaoexiste");

            //testando o retorno da consulta (tem que dar null)
            Assert.Null(resultadoConsulta);
        }
    }
}