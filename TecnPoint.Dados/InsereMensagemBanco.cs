using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados
{
    public class InsereMensagemBanco
    {
        public void InserirMensagem(DadosMensagens MensagemUsuario)
        {
            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string queryAdd = "INSERT INTO Conversa (Mensagem, fk_idRemetente, fk_idChamado) " +
                                    "VALUES (@RecebeMensagem, @RecebeIdRemetente, @RecebeIdChamado)";
                using (NpgsqlCommand comando = new NpgsqlCommand(queryAdd, conexao.conexao))
                {
                    comando.Parameters.AddWithValue("@RecebeMensagem", MensagemUsuario.Mensagem);
                    comando.Parameters.AddWithValue("@RecebeIdChamado", MensagemUsuario.IdChamado);
                    comando.Parameters.AddWithValue("@RecebeIdRemetente", MensagemUsuario.IdRemetente);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
