using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;

namespace TecnPoint.Service
{
    public class AtribuicaoChamado
    {
        AtualizaFuncionario attFunc;

        public AtribuicaoChamado()
        {
            attFunc = new AtualizaFuncionario();
        }

        public void AtribuiChamado(int idchamado, int idfuncionario)
        {
            attFunc.AtualizaFunc(idchamado, idfuncionario);
        }
    }
}
