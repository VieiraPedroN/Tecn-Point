using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TecnPoint.Modelo
{
    public class DadosChamado
    {
        private int _idChamado;
        private string _titulo;
        private string _descricao;
        private string _status;
        private string _prioridade;
        private int _idCliente;
        private int _idFuncionario;
        private int _idModulo;
        private int _idJornada;


        //Construtor que vai receber os chamados (para serem exibidos posteriormente)
        public DadosChamado(int idChamado, string titulo, string descricao, 
                                  string status, string prioridade, int idCliente, 
                                 int idFuncionario, int Modulo, int Jornada)
        {
            _idChamado = idChamado;
            _titulo = titulo;
            _descricao = descricao;
            _status = status;
            _prioridade = prioridade;
            _idCliente = idCliente;
            _idFuncionario = idFuncionario;
            _idModulo = Modulo;
            _idJornada = Jornada;
        }

        //Construtor vazio para receber os dados para abertura de chamado
        public DadosChamado()
        {
        }

        public int IdChamado
        {
            get { return _idChamado; }
            set { _idChamado = value; }
        }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string Prioridade
        {
            get { return _prioridade; }
            set { _prioridade = value; }
        }
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public int IdFuncionario
        {
            get { return _idFuncionario; }
            set { _idFuncionario = value; }
        }
        public int IdModulo
        {
            get { return _idModulo; }
            set { _idModulo = value; }
        }
        public int IdJornada
        {
            get { return _idJornada; }
            set { _idJornada = value; }
        }
    }
}
