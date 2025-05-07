using Npgsql;

namespace TecnPoint.Dados
{
    public class ClassConexaoBanco : IDisposable
    {

        private readonly string _stringconexao;
        public NpgsqlConnection conexao { get; set; } //Representa a conexao aberta com o banco

        public ClassConexaoBanco()
        {
            _stringconexao = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=SystemDB";
            conexao = new NpgsqlConnection(_stringconexao);
            conexao.Open();

        }

        public void Dispose()
        {
            conexao.Dispose();
        }

    }
}
