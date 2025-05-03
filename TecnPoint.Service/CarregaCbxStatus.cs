using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;

namespace TecnPoint.Service
{
    public class CarregaCbxStatus
    {
        CarregarStatus carregarStatus;
        public CarregaCbxStatus()
        {
            carregarStatus = new CarregarStatus();
        }

        public void CarregaStatus(ComboBox cbxForm)
        {
            carregarStatus.CarregaStatus(cbxForm);
        }
    }
}
