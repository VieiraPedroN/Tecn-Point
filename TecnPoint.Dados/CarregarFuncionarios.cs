using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo.DadosUsuario;//Lembrar disso aqui, será q da ruim?

namespace TecnPoint.Dados
{
    public class CarregarFuncionarios
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
    }
}
