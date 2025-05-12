using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;
using TecnPoint.Modelo;

namespace TecnPoint.Service
{
    public class ServMensagens
    {
        MensagensChamados mensagemChamado;

        public ServMensagens()
        {
            mensagemChamado = new MensagensChamados();
        }
        
        public List<DadosMensagens> ObterMensagens(int IdChamado, int IdUltimaMensagem)
        {
            return mensagemChamado.CarregandoMensagens(IdChamado, IdUltimaMensagem);
        }

        public void EnviarMensagem(DadosMensagens mensagemEnviada)
        {
            mensagemChamado.InserirMensagem(mensagemEnviada);
        }
    }
}
