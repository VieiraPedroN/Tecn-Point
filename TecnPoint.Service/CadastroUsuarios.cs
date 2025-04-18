using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo.DadosUsuario;
using TecnPoint.Dados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TecnPoint.Service.CadastroUsuarios
{
    public class CadastroUsuarios
    {
        private ClassRepositorioCadastro _dadosUsuarioCadastro;

        public CadastroUsuarios()
        {
            _dadosUsuarioCadastro = new ClassRepositorioCadastro();
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
    }
}