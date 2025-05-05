using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Modelo.DTO
{
    public class ExibicaoChamado
    {
        public int IdChamado { get; set; }
        public string Titulo { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFuncionario { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public string Prioridade { get; set; }
        public string NomeJornada { get; set; }
        public string NomeModulo { get; set; }
    }
}
