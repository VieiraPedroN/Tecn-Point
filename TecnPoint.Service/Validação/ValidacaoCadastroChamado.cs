using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnPoint.Service.Validação
{
    class ValidacaoCadastroChamado
    {
        public bool txtbTitulo(string titulo)
        {
            return (!string.IsNullOrWhiteSpace(titulo));
        }
        public bool txtbDescricao(string descricao)
        {
            return (!string.IsNullOrWhiteSpace(descricao));
        }
        public bool cbxModulo(ComboBox comboBox) 
        {
            return (comboBox.SelectedIndex > 0);
        }
        public bool cbxJornada(ComboBox comboBox)
        {
            return (comboBox.SelectedIndex > 0);
        }
    }
}
