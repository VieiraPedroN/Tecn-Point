using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados
{
    public class DadosUsuario : IDadosUsuario
    {
        public void CadastrarUsuario(ModeloUsuario usuarioCadastro)
        {
            using (ClassConexaoBanco conexaoCadastro = new ClassConexaoBanco())
            {
                string queryCadastro = "INSERT INTO Usuarios (Nome, Email, Senha, tipo_Usuario) " +
                    "VALUES (@RecebeNome, @RecebeEmail, @RecebeSenha, @RecebeTipoUsuario)";

                using (NpgsqlCommand comandoConsulta = new NpgsqlCommand(queryCadastro, conexaoCadastro.conexao))
                {
                    //Enviando os parâmetros para o comando
                    comandoConsulta.Parameters.AddWithValue("@RecebeNome", usuarioCadastro.Nome);
                    comandoConsulta.Parameters.AddWithValue("@RecebeEmail", usuarioCadastro.Email.ToLower());
                    comandoConsulta.Parameters.AddWithValue("@RecebeSenha", usuarioCadastro.Senha);
                    comandoConsulta.Parameters.AddWithValue("@RecebeTipoUsuario", usuarioCadastro.TipoUsuario);
                    comandoConsulta.ExecuteNonQuery();
                }
            }
        }

        public ModeloUsuario LoginUsuario(string emailConsultado, string senhaConsultada)
        {
            using (ClassConexaoBanco conexaoConsultaEmailSenha = new ClassConexaoBanco())
            {
                string query = "SELECT id_Usuario, Nome, Email, tipo_Usuario FROM Usuarios WHERE Email = @RecebeEmail AND Senha = @RecebeSenha";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexaoConsultaEmailSenha.conexao))
                {
                    //Enviando parâmetros para utilizar na consulta
                    comando.Parameters.AddWithValue("@RecebeEmail", emailConsultado);
                    comando.Parameters.AddWithValue("@RecebeSenha", senhaConsultada);

                    using (NpgsqlDataReader leitorDeColunas = comando.ExecuteReader())
                    {
                        if (leitorDeColunas.Read()) //Se encontrou algum usuário, executa
                        {
                            return new ModeloUsuario()
                            {
                                //GetOrdinal vai retornar o número da coluna com base no seu nome
                                IdUsuario = leitorDeColunas.GetInt32(leitorDeColunas.GetOrdinal("id_Usuario")),
                                Nome = leitorDeColunas.GetString(leitorDeColunas.GetOrdinal("Nome")),
                                Email = leitorDeColunas.GetString(leitorDeColunas.GetOrdinal("Email")),
                                TipoUsuario = leitorDeColunas.GetString(leitorDeColunas.GetOrdinal("tipo_Usuario"))
                            };
                        }
                    }

                }
            }
        return null; //Se o usuário não for encontrado
        }
    }
}
