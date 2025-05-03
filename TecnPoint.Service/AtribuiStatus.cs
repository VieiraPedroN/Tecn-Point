using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;

namespace TecnPoint.Service
{
    public class AtribuiStatus
    {
        AtualizarStatus attStatus;

        public AtribuiStatus()
        {
            attStatus = new AtualizarStatus();
        }

        public void AtribuirStatus(int idchamado, string status)
        {
            attStatus.AtualizaStatus(idchamado, status);
        }
    }
}
