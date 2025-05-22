using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Modelo;

namespace TecnPoint.Dados
{
    public interface IDadosUsuario
    {
        ModeloUsuario LoginUsuario(string emailConsultado, string senhaConsultada);
    }
}
