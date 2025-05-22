using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Modelo
{
    public class DadosMensagens
    {
        public int IdMensagem { get; set; }
        public string Mensagem { get; set; }
        public int IdChamado { get; set; }
        public int IdRemetente { get; set; }
        public string NomeRemetente { get; set; }

        //Construtor vazio para receber os dados do banco (recebe: idMensagem, NomeRemetente, Mensagem)
        public DadosMensagens()
        {
        }
        
        //Construtor utilizado para envio de mensagem para o banco
        public DadosMensagens(string mensagem, int idChamado, int idRemetente)
        {
            Mensagem = mensagem;
            IdChamado = idChamado;
            IdRemetente = idRemetente;
        }
    }
}
