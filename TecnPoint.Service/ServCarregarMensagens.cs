using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;
using TecnPoint.Modelo;

namespace TecnPoint.Service
{
    public class ServCarregarMensagens
    {
        CarregaMensagens carregandoMensagens;

        public ServCarregarMensagens()
        {
            carregandoMensagens = new CarregaMensagens();
        }

        public List<DadosMensagens> ObterMensagens(int IdChamado)
        {
            return carregandoMensagens.CarregandoMensagens(IdChamado);
        }
    }
}
