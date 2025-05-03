using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;

namespace TecnPoint.Service
{
    public class CarregaCbxFunc
    {
        CarregarFuncionarios carregaFunc;
        public CarregaCbxFunc()
        {
            carregaFunc = new CarregarFuncionarios(); 
        }

        public void CarregaNomeFunc(ComboBox cbxForm) 
        {
            carregaFunc.CarregaFuncionarios(cbxForm);
        }
    }
}
