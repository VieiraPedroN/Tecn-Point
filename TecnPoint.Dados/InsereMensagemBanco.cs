using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Dados
{
    public class InsereMensagemBanco
    {
        public void InserirMensagem(string Mensagem, int IdChamado, int IdRemetente)
        {
            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string queryAdd = "INSERT INTO Conversa (Mensagem, fk_idRemetente, fk_idChamado) " +
                                    "VALUES (@RecebeMensagem, @RecebeIdChamado, @RecebeIdRemetente)";
                using (NpgsqlCommand comando = new NpgsqlCommand(queryAdd, conexao.conexao))
                {
                    comando.Parameters.AddWithValue("@RecebeMensagem", Mensagem);
                    comando.Parameters.AddWithValue("@RecebeIdChamado", IdChamado);
                    comando.Parameters.AddWithValue("@RecebeIdRemetente", IdRemetente);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
