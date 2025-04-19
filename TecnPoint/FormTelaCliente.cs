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
    public partial class FormTelaCliente : Form
    {
        public FormTelaCliente()
        {
            InitializeComponent();
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
            NomeUsuario.Text = ClassDadosEstaticosUsuario.Nome;
            EmailUsuario.Text = ClassDadosEstaticosUsuario.Email;
        }
        private void botaoCriarChamado_Click(object sender, EventArgs e)
        {
            AlternarBotoes(botaoCriarChamado, botaoAcompanharChamado);
            FormTelaCadastroChamado formTelaCadastroChamado = new FormTelaCadastroChamado();
            formTelaCadastroChamado.ShowDialog();
        }
        private void botaoAcompanharChamado_Click(object sender, EventArgs e)
        {
            AlternarBotoes(botaoAcompanharChamado, botaoCriarChamado);
        }
    }
        
}
