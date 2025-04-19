using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Service;
using TecnPoint.Modelo.ClassDadosEstaticosUsuario;

namespace TecnPoint.Interface
{
    public partial class FormTelaCadastroChamado : Form
    {
        CadastroChamado cadastroChamado;
        public FormTelaCadastroChamado()
        {
            InitializeComponent();
            cadastroChamado = new CadastroChamado();
            cbxModulo.SelectedIndex = 0;
            cbxJornada.SelectedIndex = 0;
            cbxPrioridade.SelectedIndex = 0;
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {

            var cadastrou = cadastroChamado.AbrirChamado(txtbTitulo.Text, txtbDescricao.Text,
                                                            cbxPrioridade.Text, ClassDadosEstaticosUsuario.IdUsuario,
                                                            cbxModulo.SelectedIndex, cbxJornada.SelectedIndex);
            if (cadastrou == true)
            {
                MessageBox.Show("Abertura de chamado realizada", 
                                "TECN SOLUTIONS", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Abertura de chamado falhou", 
                                "TECN SOLUTIONS", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }
    }
}
