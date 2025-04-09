using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualizacao_usuario
{
    public partial class AcompanharChamado : Form
    {
        private void StatusChamado(ComboBox status)
        {
            switch (status.SelectedIndex)
            {
                case 0:
                    status.BackColor = Color.PaleGreen;
                    break;
                case 1:
                    status.BackColor = Color.PaleGoldenrod;
                    break;
                case 2:
                    status.BackColor = Color.Silver;
                    break;
                default:
                    status.BackColor = SystemColors.Window;
                    break;
            }
        }
        public AcompanharChamado()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 2;
            comboBox3.SelectedIndex = 1;
            comboBox4.SelectedIndex = 0;

            StatusChamado(comboBox1);
            StatusChamado(comboBox2);
            StatusChamado(comboBox3);
            StatusChamado(comboBox4);
        }
    }
}
