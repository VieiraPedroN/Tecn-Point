using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados.BuscarChamadoPorUsuario;
using TecnPoint.Modelo.DTO;

namespace TecnPoint.Service.ObterChamadosPorUsuario
{
    public class ObterChamadosPorUsuario
    {
        BuscarChamadoPorUsuario buscarChamadoPorUsuario;

        public ObterChamadosPorUsuario()
        {
            buscarChamadoPorUsuario = new BuscarChamadoPorUsuario();
        }

        public List<ExibicaoChamado> BuscarChamados (int idusuario, string tipousuario)
        {
            return buscarChamadoPorUsuario.ExibeChamadosUsuario(idusuario, tipousuario);
        }
    }
}
