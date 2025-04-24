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
                string queryBuscaChamadosCliente = "SELECT chamados.Titulo," +
                                                            "cliente.Nome AS NomeCliente, " +
                                                            "funcionario.Nome AS NomeFuncionario, " +
                                                            "chamados.Status, " +
                                                            "chamados.Descricao, " +
                                                            "chamados.Prioridade, " +
                                                            "jornada.Jornada AS JornadaChamado, " +
                                                            "modulo.Modulo AS ModuloChamado " +
                                                            "FROM Chamados chamados " +
                                                            "JOIN Usuarios cliente ON chamados.fk_idCliente = cliente.id_Usuario " +
                                                            "JOIN Usuarios funcionario ON chamados.fk_idFuncionario = funcionario.id_Usuario " +
                                                            "JOIN Jornada jornada ON chamados.fk_idJornada = jornada.id_Jornada " +
                                                            "JOIN Modulo modulo ON chamados.fk_idModulo = modulo.id_Modulo " +
                                                            "WHERE ";
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
                        comandoConsulta.Parameters.AddWithValue("@RecebeIdUsuario", IdUsuario);
                        using NpgsqlDataReader leitor = comandoConsulta.ExecuteReader();

                        while (leitor.Read())
                        {
                            listaRecebeDados.Add(new ExibicaoChamado
                            {
                                Titulo = leitor.GetString(leitor.GetOrdinal("Titulo")),
                                NomeCliente = leitor.GetString(leitor.GetOrdinal("NomeCliente")),
                                NomeFuncionario = leitor.GetString(leitor.GetOrdinal("NomeFuncionario")),
                                Status = leitor.GetString(leitor.GetOrdinal("Status")),
                                Descricao = leitor.GetString(leitor.GetOrdinal("Descricao")),
                                Prioridade = leitor.GetString(leitor.GetOrdinal("Prioridade")),
                                NomeJornada = leitor.GetString(leitor.GetOrdinal("JornadaChamado")),
                                NomeModulo = leitor.GetString(leitor.GetOrdinal("ModuloChamado"))
                            });
                        }
                    }
            }
            return listaRecebeDados;
        }
    }
}

