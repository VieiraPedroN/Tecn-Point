using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados
{
    public class CarregaMensagens
    {
        public List<DadosMensagens> CarregandoMensagens(int IdChamado)
        {
            List<DadosMensagens> listaDeMensagens = new List<DadosMensagens>();

            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string query = "SELECT u.Nome," +
                                      "c.Mensagem " +
                                      "FROM Conversa c " +
                                      "JOIN Usuarios u ON c.fk_idRemetente = u.id_Usuario " +
                                      "WHERE c.fk_idChamado = @RecebeIdChamado " +
                                      "ORDER BY c.Data_Hora ASC";

                using(NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    //comando.Parameters.AddWithValue("@RecebeIdRemetente", idUsuarioLogado);
                    comando.Parameters.AddWithValue("@RecebeIdChamado", IdChamado);

                    using NpgsqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        listaDeMensagens.Add(new DadosMensagens
                        {
                            Mensagem = leitor.GetString(leitor.GetOrdinal("Mensagem")),
                            NomeRemetente = leitor.GetString(leitor.GetOrdinal("Nome"))
                        });
                    }
     
                }
            }
            return listaDeMensagens;
        }
    }
}
