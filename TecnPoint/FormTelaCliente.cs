using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Modelo.ClassStaticUsuarioLogado;


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
            NomeUsuario.Text = ClassStaticUsuarioLogado.Nome;
            EmailUsuario.Text = ClassStaticUsuarioLogado.Email;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AlternarBotoes(button1, button2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AlternarBotoes(button2, button1);
        }
    }
        
}
