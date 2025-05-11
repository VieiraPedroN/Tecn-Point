using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Dados
{
    public class ClassRepositorioLoginUsuario
    {
        
        //Método para obter os dados do usuário para validar login
        public DadosUsuario ConsultaEmailSenha(string emailConsultado, string senhaConsultada)
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
                                return new DadosUsuario()
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
