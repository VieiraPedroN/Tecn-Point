using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Dados
{
    public class ClassRepositorioCadastro
    {
        public void CadastrarUsuario(DadosUsuario usuarioCadastro)
        {
            using (ClassConexaoBanco conexaoCadastro = new ClassConexaoBanco())
            {
                string queryCadastro = "INSERT INTO Usuarios (Nome, Email, Senha, tipo_Usuario) " +
                    "VALUES (@RecebeNome, @RecebeEmail, @RecebeSenha, @RecebeTipoUsuario)";

                using (NpgsqlCommand comandoConsulta = new NpgsqlCommand(queryCadastro, conexaoCadastro.conexao))
                {
                    //Enviando os parâmetros para o comando
                    comandoConsulta.Parameters.AddWithValue("@RecebeNome", usuarioCadastro.Nome);
                    comandoConsulta.Parameters.AddWithValue("@RecebeEmail", usuarioCadastro.Email);
                    comandoConsulta.Parameters.AddWithValue("@RecebeSenha", usuarioCadastro.Senha);
                    comandoConsulta.Parameters.AddWithValue("@RecebeTipoUsuario", usuarioCadastro.TipoUsuario);
                    comandoConsulta.ExecuteNonQuery();
                }
            }
        }
    }
}
