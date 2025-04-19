using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados
{
    public class ClassRepositorioAberturaChamado
    {

        public void AbreChamado(ClassDadosChamado chamadoAbertura)
        {
            using (ClassConexaoBanco conexaoCad = new ClassConexaoBanco())
            {
                string queryCadastroChamado = "INSERT INTO Chamados (Titulo, Descricao, Status, Prioridade, fk_idCliente, fk_idFuncionario, fk_idJornada, fk_idModulo)" +
                    "VALUES (@RecebeTitulo, @RecebeDescricao, @RecebeStatus, @RecebePrioridade, @RecebeIdCliente, @RecebeIdFuncionario, @RecebeIdJornada, @RecebeIdModulo)";

                using (NpgsqlCommand comandoCad = new NpgsqlCommand(queryCadastroChamado, conexaoCad.conexao))
                {
                    //Enviando parâmetros para a query
                    comandoCad.Parameters.AddWithValue("@RecebeTitulo", chamadoAbertura.Titulo);
                    comandoCad.Parameters.AddWithValue("@RecebeDescricao", chamadoAbertura.Descricao);
                    comandoCad.Parameters.AddWithValue("@RecebeStatus", chamadoAbertura.Status);
                    comandoCad.Parameters.AddWithValue("@RecebePrioridade", chamadoAbertura.Prioridade);
                    comandoCad.Parameters.AddWithValue("@RecebeIdCliente", chamadoAbertura.IdCliente);
                    comandoCad.Parameters.AddWithValue("@RecebeIdFuncionario", chamadoAbertura.IdFuncionario);
                    comandoCad.Parameters.AddWithValue("@RecebeIdJornada", chamadoAbertura.IdJornada);
                    comandoCad.Parameters.AddWithValue("@RecebeIdModulo", chamadoAbertura.IdModulo);
                    comandoCad.ExecuteNonQuery();
                }
            }
        }
    }
}
