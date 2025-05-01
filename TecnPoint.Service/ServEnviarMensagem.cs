using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;

namespace TecnPoint.Service
{
    public class ServEnviarMensagem
    {
        InsereMensagemBanco enviarMensagem;

        public ServEnviarMensagem()
        {
            enviarMensagem = new InsereMensagemBanco();
        }

        public void EnviarMensagem(string Mensagem, int IdChamado, int IdRemetente)
        {
            enviarMensagem.InserirMensagem(Mensagem, IdChamado, IdRemetente);
        }

    }
}
