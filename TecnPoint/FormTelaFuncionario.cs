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
    public partial class FormTelaFuncionario : Form
    {
        public FormTelaFuncionario()
        {
            InitializeComponent();
        }

        private void FormTelaFuncionario_Closed(object sender, EventArgs e)
        {
            FormTelaLogin telaLogin = new FormTelaLogin();
            telaLogin.Show();
        }

        private void FormTelaFuncionario_Load(object sender, EventArgs e)
        {
            NomeUsuario.Text = ClassStaticUsuarioLogado.Nome;
            EmailUsuario.Text = ClassStaticUsuarioLogado.Email;
        }
    }
}
