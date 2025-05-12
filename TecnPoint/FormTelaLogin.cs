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
            this.AcceptButton = btnEntrarLogin;
        }
        public void DefinirModoDaltonico(bool modo)
        {
            chcbModoDaltonico.Checked = modo;
        }

        public bool ModoDaltonicoAtivo => chcbModoDaltonico.Checked;

        private void botaoEntrarLogin_Click(object sender, EventArgs e)
        {
            var usuarioLogado = _loginUsuario.RealizarLogin(EntradaEmail.Text.ToLower(), EntradaSenha.Text);

            if (usuarioLogado != null)
            {
                if (usuarioLogado.TipoUsuario == "Funcionário")
                {
                    FormTelaFuncionario telaFuncionario = new FormTelaFuncionario(usuarioLogado, ModoDaltonicoAtivo);
                    telaFuncionario.Show();
                    this.Hide();
                }
                else
                {
                    FormTelaCliente telaCliente = new FormTelaCliente(usuarioLogado, ModoDaltonicoAtivo);
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



        private void AtivarModoDaltonico()
        {
            this.BackgroundImage = Interface.Properties.Resources.TelaInicioDaltonico;

            btnEntrarLogin.BackColor = Color.FromArgb(171, 126, 105);
        }

        private void DesativarModoDaltonico()
        {
            this.BackgroundImage = Interface.Properties.Resources.TelaFundoLogin;

            btnEntrarLogin.BackColor = Color.FromArgb(126, 105, 171);
        }

        private void chcbModoDaltonico_CheckedChanged(object sender, EventArgs e)
        {
            if (chcbModoDaltonico.Checked)
            {
                AtivarModoDaltonico();
            }
            else
            {
                DesativarModoDaltonico();
            }
        }
    }
}
