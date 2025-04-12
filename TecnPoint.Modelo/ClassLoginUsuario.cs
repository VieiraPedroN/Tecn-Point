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
        private int _funcao;

        public ClassLoginUsuario(string email, string senha, int funcao) 
        {
            _email = email;
            _senha = senha;
            _funcao = funcao;
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
        public int Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }

        public bool ValidarLogin(string entradaEmail, string entradaSenha)
        {
            return _email == entradaEmail && _senha == entradaSenha;
        }
    }
}        

