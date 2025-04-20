using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados.BuscarChamadoPorCliente;
using TecnPoint.Modelo;

namespace TecnPoint.Service.ObterChamadosPorUsuario
{
    public class ObterChamadosPorUsuario
    {
        BuscarChamadoPorCliente buscarChamadoPorCliente;

        public ObterChamadosPorUsuario()
        {
            buscarChamadoPorCliente = new BuscarChamadoPorCliente();
        }

        public List<ExibicaoChamado> BuscarChamados (int idusuario, string tipousuario)
        {
            return buscarChamadoPorCliente.ExibeChamadosCliente(idusuario, tipousuario);
        }
    }
}
