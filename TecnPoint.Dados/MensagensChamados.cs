using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados
{
    public class MensagensChamados
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

        public List<DadosMensagens> CarregandoMensagens(int IdChamado, int IdUltimaMensagem)
        {
            List<DadosMensagens> listaDeMensagens = new List<DadosMensagens>();

            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string query = "SELECT c.id_Conversa, " +
                                      "u.Nome," +
                                      "c.Mensagem " +
                                      "FROM Conversa c " +
                                      "JOIN Usuarios u ON c.fk_idRemetente = u.id_Usuario " +
                                      "WHERE c.fk_idChamado = @RecebeIdChamado AND id_Conversa > @RecebeIdUltimaMensagem " +
                                      "ORDER BY c.Data_Hora ASC";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    //comando.Parameters.AddWithValue("@RecebeIdRemetente", idUsuarioLogado);
                    comando.Parameters.AddWithValue("@RecebeIdChamado", IdChamado);
                    comando.Parameters.AddWithValue("@RecebeIdUltimaMensagem", IdUltimaMensagem);

                    using NpgsqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        listaDeMensagens.Add(new DadosMensagens
                        {
                            Mensagem = leitor.GetString(leitor.GetOrdinal("Mensagem")),
                            NomeRemetente = leitor.GetString(leitor.GetOrdinal("Nome")),
                            IdMensagem = leitor.GetInt32(leitor.GetOrdinal("id_Conversa"))
                        });
                    }

                }
            }
            return listaDeMensagens;
        }
    }
}
