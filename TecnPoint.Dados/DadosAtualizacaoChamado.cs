using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Dados
{
    public class DadosAtualizacaoChamado
    {
        public void CarregaFuncionarios(ComboBox comboboxFunc)
        {
            List<DadosUsuario> ListaNomeFunc = new List<DadosUsuario>();

            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                string query = "SELECT id_Usuario, Nome FROM Usuarios WHERE tipo_Usuario = 'Funcionário'";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            ListaNomeFunc.Add(new DadosUsuario
                            {
                                IdUsuario = leitor.GetInt32(leitor.GetOrdinal("id_Usuario")),
                                Nome = leitor.GetString(leitor.GetOrdinal("Nome"))
                            });
                        }
                    }
                }
            }
            comboboxFunc.DataSource = ListaNomeFunc;
            comboboxFunc.DisplayMember = "Nome";
            comboboxFunc.ValueMember = "IdUsuario";
        }

        public void AtualizaFunc(int idChamado, int idFunc)
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
        }

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

        public void AtualizaStatus(int idChamado, string status)
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
        }
    }
}
