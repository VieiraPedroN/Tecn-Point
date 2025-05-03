using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TecnPoint.Modelo;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Dados
{
    public class CarregarStatus
    {
        public void CarregaStatus(ComboBox comboBoxStatus)
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Aberto");
            comboBoxStatus.Items.Add("Pendente");
            comboBoxStatus.Items.Add("Resolvido");
            comboBoxStatus.SelectedIndex = 0;

            List<DadosChamado> ListaStatus = new List<DadosChamado>();

            using (ClassConexaoBanco conexao = new ClassConexaoBanco())
            {
                // Query sem o filtro, para listar todos os status
                string query = "SELECT DISTINCT Status FROM Chamados";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao.conexao))
                {
                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            // Adicionando cada status na lista
                            ListaStatus.Add(new DadosChamado
                            {
                                Status = leitor.GetString(leitor.GetOrdinal("Status"))
                            });
                        }
                    }
                }
            }

            comboBoxStatus.DataSource = ListaStatus;
            comboBoxStatus.DisplayMember = "Status";
            comboBoxStatus.ValueMember = "Status"; // Usando "Status" como ValueMember
        }
    }
}
