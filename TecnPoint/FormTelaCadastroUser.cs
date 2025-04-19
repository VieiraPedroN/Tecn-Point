using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Service.CadastroUsuarios;

namespace TecnPoint.Interface
{
    public partial class FormTelaCadastroUser : Form
    {
        CadastroUsuarios cadastroUsuarios = new CadastroUsuarios();
        public FormTelaCadastroUser()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cadastro = cadastroUsuarios.CadastrarUsuario(txtbNome.Text, txtbEmail.Text, txtbSenha.Text, cbbTipoUsuário.Text);
            if (cadastro == true)
            {
                MessageBox.Show("Deu certo", "Returno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
