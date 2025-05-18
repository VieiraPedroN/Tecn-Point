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

            ModeloUsuario usuarioCadastrado = new ModeloUsuario
            {
                IdUsuario = 1,
                Nome = "TesteCliente",
                Email = "teste@gmail.com",
                Senha = "teste123",
                TipoUsuario = "Cliente"
            };

            mockDados.Setup(repo => repo.LoginUsuario("teste@gmail.com", "teste123"))
                .Returns(usuarioCadastrado);

            var servLogin = mockDados.Object;

            ModeloUsuario resultadoConsulta = servLogin.LoginUsuario("teste@gmail.com", "teste123");

            Assert.NotNull(resultadoConsulta);
            Assert.Equal(resultadoConsulta.Email, usuarioCadastrado.Email);
            Assert.Equal(resultadoConsulta.Nome, usuarioCadastrado.Nome);
            Assert.Equal(resultadoConsulta.TipoUsuario, usuarioCadastrado.TipoUsuario);
        }

        [Fact]
        public void LoginUsuario_DeveRetornarNull_SeUsuarionaoExistirNoBancoDeDados()
        {
            var mockDados = new Mock<IDadosUsuario>();

            mockDados.Setup(repo => repo.LoginUsuario("emailtestenulo@gmail.com", "senhanaoexiste"))
                .Returns((ModeloUsuario)null);

            var servLogin = mockDados.Object;

            ModeloUsuario resultadoConsulta = servLogin.LoginUsuario("emailtestenulo@gmail.com", "senhanaoexiste");


            //testando o retorno da consulta (tem q dar null)
            Assert.Null(resultadoConsulta);
        }
    }
}