using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Modelo.DadosUsuario
{
    public class DadosUsuario
    {
        private int _idUsuario;
        private string _nome;
        private string _email;
        private string _senha;
        private string _tipoUsuario;

        public DadosUsuario(int idUsuario, string nome, string email, string senha, string tipoUsuario)
        {
            _idUsuario = idUsuario;
            _nome = nome;
            _email = email;
            _senha = senha;
            _tipoUsuario = tipoUsuario;
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public string TipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }
    }
}

