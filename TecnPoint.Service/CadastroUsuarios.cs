using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo.DadosUsuario;
using TecnPoint.Dados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TecnPoint.Service.Validação;

namespace TecnPoint.Service.CadastroUsuarios
{
    public class CadastroUsuarios
    {
        private ValidacaoCadastroUser _validacaoCadastro;
        private ClassRepositorioCadastro _dadosUsuarioCadastro;

        public CadastroUsuarios()
        {
            _dadosUsuarioCadastro = new ClassRepositorioCadastro();
            _validacaoCadastro  = new ValidacaoCadastroUser();
        }

        public bool CadastrarUsuario(string Nome, string Email, string Senha, string Tipo_Usuario)
        {
            //validações
            DadosUsuario dadosUsuario = new DadosUsuario()
            {
                Nome = Nome,
                Email = Email,
                Senha = Senha,
                TipoUsuario = Tipo_Usuario
            };
            _dadosUsuarioCadastro.CadastrarUsuario(dadosUsuario);
            return true;
        }

        public bool ValidarNome(string nome) 
        {
            return _validacaoCadastro.NomeValido(nome);
        }
        public bool ValidarEmail(string email)
        {
            return _validacaoCadastro.EmailValido(email);
        }
        public bool ValidarSenha(string senha)
        {
            return _validacaoCadastro.SenhaValido(senha);
        }
        public bool ValidarTipoUsuario(string tipoUsuario) 
        {
            return _validacaoCadastro.TipoUsuárioValido(tipoUsuario);
        }
    }
}