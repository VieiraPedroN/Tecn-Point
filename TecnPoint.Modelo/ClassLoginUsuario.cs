using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Modelo.ClassLoginUsuario
{
    public class ClassLoginUsuario
    {
        private string _email;
        private string _senha;
        private string _tipoUsuario;


        public ClassLoginUsuario(string email, string senha, string tipoUsuario) 
        {
            _email = email;
            _senha = senha;
            _tipoUsuario = tipoUsuario;
        }

        public string Email
        { 
            get {  return _email; } 
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

        public bool ValidarLogin(string entradaEmail, string entradaSenha)
        {
            return _email == entradaEmail && _senha == entradaSenha;
        }
    }
}        

