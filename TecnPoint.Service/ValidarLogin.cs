using TecnPoint.Dados;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Service.ValidarLogin
{
    public class ValidarLogin
    {
        private ClassRepositorioLoginUsuario _loginUsuario;

        public ValidarLogin() 
        {
            _loginUsuario = new ClassRepositorioLoginUsuario();
        }

        public DadosUsuario Checar(string EntradaEmail, string EntradaSenha)
        {
            return _loginUsuario.ConsultaEmailSenha(EntradaEmail, EntradaSenha);
        }
    }
}
