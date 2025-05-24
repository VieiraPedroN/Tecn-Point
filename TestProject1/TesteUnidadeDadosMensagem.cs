using TecnPoint.Modelo;
using Xunit;

namespace TecnPoint.Tests.Modelo
{
    public class DadosMensagensTests
    {
        [Fact]
        public void ConstrutorVazio_DevePermitirDefinirPropriedades()
        {
            // Arrange
            var dados = new DadosMensagens();

            // Act
            dados.IdMensagem = 1;
            dados.Mensagem = "Teste de mensagem";
            dados.IdChamado = 101;
            dados.IdRemetente = 5;
            dados.NomeRemetente = "Carlos";

            // Assert
            Assert.Equal(1, dados.IdMensagem);
            Assert.Equal("Teste de mensagem", dados.Mensagem);
            Assert.Equal(101, dados.IdChamado);
            Assert.Equal(5, dados.IdRemetente);
            Assert.Equal("Carlos", dados.NomeRemetente);
        }

        [Fact]
        public void ConstrutorComParametros_DeveAtribuirValoresCorretamente()
        {
            // Arrange
            string mensagem = "Mensagem para o banco";
            int idChamado = 202;
            int idRemetente = 8;

            // Act
            var dados = new DadosMensagens(mensagem, idChamado, idRemetente);

            // Assert
            Assert.Equal(mensagem, dados.Mensagem);
            Assert.Equal(idChamado, dados.IdChamado);
            Assert.Equal(idRemetente, dados.IdRemetente);
        }
    }
}
