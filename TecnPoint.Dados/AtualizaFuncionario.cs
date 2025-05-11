using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Dados
{
    public class AtualizaFuncionario
    {
        /*public void AtualizaFunc(int idChamado, int idFunc)
        {
            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string query = "UPDATE Chamados SET fk_idFuncionario = @RecebeIdFunc WHERE id_Chamado = @RecebeIdChamado";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    comando.Parameters.AddWithValue("@RecebeIdFunc", idFunc);
                    comando.Parameters.AddWithValue("@RecebeIdChamado", idChamado);

                    int linhasAlteradas = comando.ExecuteNonQuery();
                    if (linhasAlteradas == 1)
                    {
                        MessageBox.Show("Funcionário atribuído ao chamado com sucesso!", "TECN POINT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atribuir funcionário ao chamado!", "TECN POINT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }*/
    }
}
