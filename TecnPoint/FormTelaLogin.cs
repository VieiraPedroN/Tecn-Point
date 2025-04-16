using TecnPoint.Dados;
using TecnPoint.Modelo.ClassDadosEstaticosUsuario;
using TecnPoint.Interface;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint
{
    public partial class FormTelaLogin : Form
    {
        //Criando objeto para passar os dados para o usuário
        ClassRepositorioLoginUsuario dadosUsuarioLogado = new ClassRepositorioLoginUsuario();
        DadosUsuario usuarioLogado = new DadosUsuario(idUsuario: 0, nome: "", email: "", senha: "", tipoUsuario: "");

        public FormTelaLogin()
        {
            InitializeComponent();
        }

        private void botaoEntrarLogin_Click(object sender, EventArgs e)
        {

            usuarioLogado = dadosUsuarioLogado.ConsultaEmailSenha(EntradaEmail.Text, EntradaSenha.Text);

            if (usuarioLogado != null)
            {
                MessageBox.Show("Login válido",
                                "Tecn Solutions",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                ClassDadosEstaticosUsuario.Nome = usuarioLogado.Nome;
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
                               "Tecn Solutions",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }

        }
    }
}
