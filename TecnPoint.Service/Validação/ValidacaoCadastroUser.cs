using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Service.Validação
{
    internal class ValidacaoCadastroUser    
    {
        public bool NomeValido(string nome)
        {
            return (!string.IsNullOrWhiteSpace(nome));
        }
        public bool EmailValido(string email)
        {
            return (!string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains("."));
        }
        public bool SenhaValido(string senha)
        {
            return (!string.IsNullOrWhiteSpace(senha));
        }
        public bool TipoUsuárioValido(string tipoUsuario)
        {
            return (!string.IsNullOrWhiteSpace(tipoUsuario));
        }
    }
}
