using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;


namespace TecnPoint.Service
{
    public class ServAtualizaChamado
    {
        AtualizacaoChamado atualizaChamado;

        public ServAtualizaChamado()
        {
            atualizaChamado = new AtualizacaoChamado();
        }

        public void AtribuirStatus(int idchamado, string status)
        {
            atualizaChamado.AtualizaStatus(idchamado, status);
        }

        public void AtribuirPrioridades(int idchamado, string prioridade)
        {
            atualizaChamado.AtualizarPrioridade(idchamado, prioridade);
        }
        public void AtribuiChamadoParaFuncionario(int idchamado, int idfuncionario)
        {
            atualizaChamado.AtualizaFunc(idchamado, idfuncionario);
        }
    }
}
