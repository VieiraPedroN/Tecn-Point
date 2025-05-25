using TecnPoint.Modelo;
using Xunit;

namespace TecnPoint.modeloteste
{
    public class ModeloUsuarioTests
    {
        [Fact]
        public void ConstrutorPadrao_DeveCriarObjeto()
        {
            // Act
            var usuario = new ModeloUsuario();

            // Assert
            Assert.NotNull(usuario);
        }

        [Fact]
        public void ConstrutorComParametros_DeveAtribuirPropriedadesCorretamente()
        {
            // Arrange
            int id = 1;
            string nome = "João";
            string email = "joao@email.com";
            string senha = "1234";
            string tipo = "Administrador";

            // Act
            var usuario = new ModeloUsuario(id, nome, email, senha, tipo);

            // Assert
            Assert.Equal(id, usuario.IdUsuario);
            Assert.Equal(nome, usuario.Nome);
            Assert.Equal(email, usuario.Email);
            Assert.Equal(senha, usuario.Senha);
            Assert.Equal(tipo, usuario.TipoUsuario);
        }

        [Fact]
        public void Setters_DeveAtualizarValoresDasPropriedades()
        {
            // Arrange
            var usuario = new ModeloUsuario();

            // Act
            usuario.IdUsuario = 10;
            usuario.Nome = "Maria";
            usuario.Email = "maria@email.com";
            usuario.Senha = "abcd";
            usuario.TipoUsuario = "Suporte";

            // Assert
            Assert.Equal(10, usuario.IdUsuario);
            Assert.Equal("Maria", usuario.Nome);
            Assert.Equal("maria@email.com", usuario.Email);
            Assert.Equal("abcd", usuario.Senha);
            Assert.Equal("Suporte", usuario.TipoUsuario);
        }
    }
}
