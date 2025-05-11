using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Dados
{
    public class AtualizarStatus
    {
        /*public void AtualizaStatus(int idChamado, string status)
        {
            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string query = "UPDATE Chamados SET Status = @RecebeStatus WHERE id_Chamado = @RecebeIdChamado";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    comando.Parameters.AddWithValue("@RecebeStatus", status);
                    comando.Parameters.AddWithValue("@RecebeIdChamado", idChamado);

                    int linhasAlteradas = comando.ExecuteNonQuery();
                    if (linhasAlteradas == 1)
                    {
                        MessageBox.Show("Status atribuído ao chamado com sucesso!", "TECN POINT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atribuir status ao chamado!", "TECN POINT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }*/
    }
}
