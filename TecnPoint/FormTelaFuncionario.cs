using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Modelo.ClassDadosEstaticosUsuario;

namespace TecnPoint.Interface
{
    public partial class FormTelaFuncionario : Form
    {
        public FormTelaFuncionario()
        {
            InitializeComponent();
        }
        /*private void AlternarBotoes(Button ativo, Button inativo)
        /{
            ativo.BackColor = Color.FromArgb(163, 89, 253);
            inativo.BackColor = Color.Transparent;
        }*/
        private void FormTelaCliente_Closed(object sender, EventArgs e)
        {
            FormTelaLogin telaLogin = new FormTelaLogin();
            telaLogin.Show();
        }
        private void FormTelaCliente_Load(object sender, EventArgs e)
        {
            NomeUsuario.Text = ClassDadosEstaticosUsuario.Nome;
            EmailUsuario.Text = ClassDadosEstaticosUsuario.Email;
        }
        private void botaoAcompanharChamado_Click(object sender, EventArgs e)
        {
            botaoAcompanharChamado.BackColor = Color.FromArgb(163, 89, 253);
        }
    }
        
}
