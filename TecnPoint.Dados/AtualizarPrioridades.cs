using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Dados
{
    public class AtualizarPrioridades
    {
        public void AtualizarPrioridade(int idChamado, string prioridade)
        {
            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string query = "UPDATE Chamados SET Prioridade = @RecebePrioridade WHERE id_Chamado = @RecebeIdChamado";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    comando.Parameters.AddWithValue("@RecebePrioridade", prioridade);
                    comando.Parameters.AddWithValue("@RecebeIdChamado", idChamado);

                    int linhasAlteradas = comando.ExecuteNonQuery();
                    if (linhasAlteradas == 1)
                    {
                        MessageBox.Show("Prioridade atribuída ao chamado com sucesso!", "TECN POINT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atribuir prioridade ao chamado!", "TECN POINT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
