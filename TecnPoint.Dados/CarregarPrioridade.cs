using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados
{
    public class CarregarPrioridade
    {
        public void CarregaPrioridade(ComboBox comboBoxPrioridades)
        {
            comboBoxPrioridades.Items.Clear();
            comboBoxPrioridades.Items.Add("Baixa");
            comboBoxPrioridades.Items.Add("Média");
            comboBoxPrioridades.Items.Add("Alta");
            comboBoxPrioridades.SelectedIndex = 0;
            List<DadosChamado> ListaPrioridade = new List<DadosChamado>();

            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                // Query sem o filtro, para listar todos os status
                string query = "SELECT DISTINCT Prioridade FROM Chamados";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            // Adicionando cada status na lista
                            ListaPrioridade.Add(new DadosChamado
                            {
                                Status = leitor.GetString(leitor.GetOrdinal("Prioridade"))
                            });
                        }
                    }
                }
            }

            comboBoxPrioridades.DataSource = ListaPrioridade;
            comboBoxPrioridades.DisplayMember = "Prioridade";
            comboBoxPrioridades.ValueMember = "Prioridade";
        }
    }
}
