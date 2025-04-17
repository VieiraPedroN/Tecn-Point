using TecnPoint.Dados;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Service.ValidarLogin
{
    public class ValidarLogin
    {
        ClassRepositorioLoginUsuario dadosUsuarioLogado = new ClassRepositorioLoginUsuario();
        DadosUsuario usuarioLogado = new DadosUsuario(idUsuario: 0, nome: "", email: "", senha: "", tipoUsuario: "");

        public void Checar(string EntradaEmail, string EntradaSenha)
        {
            dadosUsuarioLogado.ConsultaEmailSenha(EntradaEmail, EntradaSenha);
        }
        
        
    }
}
