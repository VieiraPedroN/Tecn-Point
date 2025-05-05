using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Modelo.DadosUsuario;


namespace TecnPoint.Interface
{
    public partial class FormTelaCliente : Form
    {
        private DadosUsuario usuarioLogado;
        public FormTelaCliente(DadosUsuario dadosUsuario)
        {
            this.usuarioLogado = dadosUsuario;
            InitializeComponent();
        }
        private void CarregarFormularioForm(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }
        private void AlternarBotoes(Button ativo, Button inativo)
        {
            ativo.BackColor = Color.FromArgb(163, 89, 253);
            inativo.BackColor = Color.Transparent;
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
        private void botaoCriarChamado_Click(object sender, EventArgs e)
        {
            AlternarBotoes(botaoCriarChamado, botaoAcompanharChamado);
            CarregarFormularioForm(new FormTelaCadastroChamado(usuarioLogado));

        }
        private void botaoAcompanharChamado_Click(object sender, EventArgs e)
        {
            AlternarBotoes(botaoAcompanharChamado, botaoCriarChamado);
            CarregarFormularioForm(new FormTelaAcompanharChamado(usuarioLogado));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTelaChatbot telachatbot = new FormTelaChatbot();
            telachatbot.ShowDialog();
        }
    }

}
