using TecnPoint.Modelo.ClassDadosEstaticosUsuario;
using TecnPoint.Interface;
using TecnPoint.Service.ValidarLogin;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint
{
    public partial class FormTelaLogin : Form
    {

        public FormTelaLogin()
        {   
            
            InitializeComponent();
        }

        private void botaoEntrarLogin_Click(object sender, EventArgs e)
        {
            
            ValidarLogin validarLogin = new ValidarLogin(dadosUsuario: DadosU);
            if (validarLogin.Checar(EmailLogin.Text, SenhaLogin.Text) != null)
            {
                ClassDadosEstaticosUsuario.Nome = .Nome;
                ClassDadosEstaticosUsuario.Email = usuarioLogado.Email;

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
