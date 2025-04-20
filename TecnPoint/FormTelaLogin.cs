using TecnPoint.Modelo.ClassDadosEstaticosUsuario;
using TecnPoint.Interface;
using TecnPoint.Service.ValidarLogin;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint
{
    public partial class FormTelaLogin : Form
    {
        private ValidarLogin validarLogin = new ValidarLogin();

        public FormTelaLogin()
        {   
            InitializeComponent();
        }

        private void botaoEntrarLogin_Click(object sender, EventArgs e)
        {
            var usuarioLogado = validarLogin.Checar(EntradaEmail.Text, EntradaSenha.Text);

            if (usuarioLogado != null)
            {
                ClassDadosEstaticosUsuario.Nome = usuarioLogado.Nome;
                ClassDadosEstaticosUsuario.Email = usuarioLogado.Email;
                ClassDadosEstaticosUsuario.IdUsuario = usuarioLogado.IdUsuario;
                ClassDadosEstaticosUsuario.TipoUsuario = usuarioLogado.TipoUsuario;

                if (usuarioLogado.TipoUsuario == "Funcionário")
                {
                    FormTelaFuncionario telaFuncionario = new FormTelaFuncionario();
                    telaFuncionario.Show();
                    this.Hide();
                }
                else
                {
                    FormTelaCliente telaCliente = new FormTelaCliente();
                    telaCliente.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login inválido",
                    "Erro ao executar essa ação", 
                            MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }

        }
    }
}
