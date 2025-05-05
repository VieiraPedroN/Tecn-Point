using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Modelo
{
    public class DadosMensagens
    {
        
        public string Mensagem { get; set; }
        public int IdChamado { get; set; }
        public int IdRemetente { get; set; }
        public string NomeRemetente { get; set; }

        public DadosMensagens(string mensagem, int idchamado, int idremetente)
        {
            Mensagem = mensagem;
            IdChamado = idchamado;
            IdRemetente = idremetente;
        }
        public DadosMensagens(string mensagem, int idchamado)
        {
            Mensagem = mensagem;
            IdChamado = idchamado;
        }
        public DadosMensagens() { }
    }
}
