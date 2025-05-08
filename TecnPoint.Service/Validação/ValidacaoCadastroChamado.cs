using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Service.Validação
{
    class ValidacaoCadastroChamado
    {
        public bool cbxModulo(string modelo)
        {
            return (!string.IsNullOrWhiteSpace(modelo));
        }

        public bool cbxJornada(string jornada)
        {
            return (!string.IsNullOrWhiteSpace(jornada));
        }

        public bool cbxPrioridade(string propiedade)
        {
            return (!string.IsNullOrWhiteSpace(propiedade));
        }

        public bool txtbTitulo(string titulo)
        {
            return (!string.IsNullOrWhiteSpace(titulo));
        }

        public bool txtbDescricao(string descricao)
        {
            return (!string.IsNullOrWhiteSpace(descricao));
        }

    }
}
