using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;
using TecnPoint.Modelo;

namespace TecnPoint.Service
{
    public class ServEnviarMensagem
    {
        InsereMensagemBanco enviarMensagem;

        public ServEnviarMensagem()
        {
            enviarMensagem = new InsereMensagemBanco();
        }

        public void EnviarMensagem(DadosMensagens mensagemEnviada)
        {
            enviarMensagem.InserirMensagem(mensagemEnviada);
        }

    }
}
