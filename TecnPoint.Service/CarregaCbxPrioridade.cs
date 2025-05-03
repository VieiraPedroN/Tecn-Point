using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;

namespace TecnPoint.Service
{
    public class CarregaCbxPrioridade
    {
        CarregarPrioridade carregarPrioridade;
        public CarregaCbxPrioridade()
        {
            carregarPrioridade = new CarregarPrioridade();
        }

        public void CarregaPrioridade(ComboBox cbxForm)
        {
            carregarPrioridade.CarregaPrioridade(cbxForm);
        }
    }
}
