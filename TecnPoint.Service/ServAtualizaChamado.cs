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
        DadosAtualizacaoChamado atualizaChamado;

        public ServAtualizaChamado()
        {
            atualizaChamado = new DadosAtualizacaoChamado();
        }
        public void CarregaNomeFunc(ComboBox cbxForm)
        {
            atualizaChamado.CarregaFuncionarios(cbxForm);
        }

        public void AtribuiChamadoParaFuncionario(int idchamado, int idfuncionario)
        {
            atualizaChamado.AtualizaFunc(idchamado, idfuncionario);
        }
        public void AtribuirStatus(int idchamado, string status)
        {
            atualizaChamado.AtualizaStatus(idchamado, status);
        }

        public void AtribuirPrioridades(int idchamado, string prioridade)
        {
            atualizaChamado.AtualizarPrioridade(idchamado, prioridade);
        }
        
    }
}
