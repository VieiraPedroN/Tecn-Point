using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;

namespace TecnPoint.Service
{
    public class AtribuiPrioridade
    {
        AtualizarPrioridades attPrioridade;

        public AtribuiPrioridade()
        {
            attPrioridade = new AtualizarPrioridades();
        }

        public void AtribuirPrioridades(int idchamado, string prioridade)
        {
            attPrioridade.AtualizarPrioridade(idchamado, prioridade);
        }
    }
}
