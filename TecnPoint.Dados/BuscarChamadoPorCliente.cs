using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados.BuscarChamadoPorCliente
{
    public class BuscarChamadoPorCliente
    {
        public List<ExibicaoChamado> ExibeChamadosCliente(int IdUsuario, string TipoUsuario)
        {
            List<ExibicaoChamado> listaRecebeDados = new List<ExibicaoChamado>();

            using (ClassConexaoBanco conexaoBuscaChamado = new ClassConexaoBanco())
            {
                string queryBuscaChamadosCliente = "SELECT c.Titulo, cli.Nome AS NomeCliente, func.Nome AS NomeFuncionario, c.Status FROM Chamados c JOIN Usuarios cli ON c.fk_idCliente = cli.id_Usuario JOIN Usuarios func ON c.fk_idFuncionario = func.id_Usuario WHERE ";
                if (TipoUsuario == "Cliente")
                {
                    queryBuscaChamadosCliente += "fk_idCliente = @RecebeIdUsuario";
                }
                else
                {
                    queryBuscaChamadosCliente += "fk_idFuncionario = @RecebeIdUsuario";
                }

                    using (NpgsqlCommand comandoConsulta = new NpgsqlCommand(queryBuscaChamadosCliente, conexaoBuscaChamado.conexao))
                    {
                        comandoConsulta.Parameters.AddWithValue("RecebeIdUsuario", IdUsuario);
                        using NpgsqlDataReader leitor = comandoConsulta.ExecuteReader();

                        while (leitor.Read())
                        {
                            listaRecebeDados.Add(new ExibicaoChamado
                            {
                                Titulo = leitor.GetString(leitor.GetOrdinal("Titulo")),
                                NomeCliente = leitor.GetString(leitor.GetOrdinal("NomeCliente")),
                                NomeFuncionario = leitor.GetString(leitor.GetOrdinal("NomeFuncionario")),
                                Status = leitor.GetString(leitor.GetOrdinal("Status")),
                            });
                        }
                    }
            }
            return listaRecebeDados;
        }
    }
}

