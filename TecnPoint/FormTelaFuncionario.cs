using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Modelo;

namespace TecnPoint.Interface
{
    public partial class FormTelaFuncionario : Form
    {
        private ModeloUsuario usuarioLogado;
        public FormTelaFuncionario(ModeloUsuario dadosUsuario)
        {
            InitializeComponent();
            this.usuarioLogado = dadosUsuario;
        }
        /*private void AlternarBotoes(Button ativo, Button inativo)
        /{
            ativo.BackColor = Color.FromArgb(163, 89, 253);
            inativo.BackColor = Color.Transparent;
        }*/
        private void CarregarFormularioForm(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }
        private void FormTelaCliente_Closed(object sender, EventArgs e)
        {
            FormTelaLogin telaLogin = new FormTelaLogin();
            telaLogin.Show();
        }
        private void FormTelaCliente_Load(object sender, EventArgs e)
        {
            NomeUsuario.Text = usuarioLogado.Nome;
            EmailUsuario.Text = usuarioLogado.Email;
        }
        private void botaoAcompanharChamado_Click(object sender, EventArgs e)
        {
            botaoAcompanharChamado.BackColor = Color.FromArgb(163, 89, 253);
            CarregarFormularioForm(new FormTelaAcompanharChamado(usuarioLogado));
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CarregarFormularioForm(new FormTelaCadastroUser());
        }
    }
}
