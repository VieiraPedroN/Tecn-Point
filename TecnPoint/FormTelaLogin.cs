using TecnPoint.Interface;
using TecnPoint.Service;
using TecnPoint.Modelo;

namespace TecnPoint
{
    public partial class FormTelaLogin : Form
    {
        private ServUsuario _loginUsuario = new ServUsuario();

        public FormTelaLogin()
        {
            InitializeComponent();
            this.AcceptButton = botaoEntrarLogin;
        }

        private void botaoEntrarLogin_Click(object sender, EventArgs e)
        {
            var usuarioLogado = _loginUsuario.RealizarLogin(EntradaEmail.Text.ToLower(), EntradaSenha.Text);

            if (usuarioLogado != null)
            {
                if (usuarioLogado.TipoUsuario == "Funcionário")
                {
                    FormTelaFuncionario telaFuncionario = new FormTelaFuncionario(usuarioLogado);
                    telaFuncionario.Show();
                    this.Hide();
                }
                else
                {
                    FormTelaCliente telaCliente = new FormTelaCliente(usuarioLogado);
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
