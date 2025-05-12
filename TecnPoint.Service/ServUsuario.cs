using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;
using TecnPoint.Modelo;
using TecnPoint.Service.Validação;

namespace TecnPoint.Service
{
    public class ServUsuario
    {
        private ValidacaoCadastroUser _validacaoCadastro;
        private DadosUsuario _dadosUsuario;

        public ServUsuario()
        {
            _dadosUsuario = new DadosUsuario();
            _validacaoCadastro = new ValidacaoCadastroUser();
        }

        public bool CadastrarUsuario(string Nome, string Email, string Senha, string Tipo_Usuario)
        {
            ModeloUsuario novoUsuario = new ModeloUsuario()
            {
                Nome = Nome,
                Email = Email,
                Senha = Senha,
                TipoUsuario = Tipo_Usuario
            };
            _dadosUsuario.CadastrarUsuario(novoUsuario);
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

        public ModeloUsuario RealizarLogin(string EntradaEmail, string EntradaSenha)
        {
            return _dadosUsuario.LoginUsuario(EntradaEmail, EntradaSenha);
        }

    }
}
