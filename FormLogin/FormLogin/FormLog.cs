using Npgsql;
using Dapper;
using System.Threading;

namespace FormLogin
{
    public partial class FormLog : Form
    {
        Thread Thread_Cliente;
        Thread Thread_Funcionario;
        public FormLog()
        {
            InitializeComponent();
        }

        public class Usuario
        {
            public string nomeUsurio { get; set; }
            public string emailUsuario { get; set; }
            public string senhaUsuario { get; set; }
            public string tipoUsuario { get; set; }

        }

        private void Button_Entrar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection Conexao = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=ADMIN;Database=SystemDB"))
            {
                string queryConsultaEmailSenha = "SELECT Nome AS nomeUsuario, Email AS emailUsuario, Senha AS senhaUsuario, tipo_Usuario AS tipoUsuario FROM Usuarios WHERE Email = @recebeEmailUsuario AND Senha = @recebeSenhaUsuario";

                Usuario usuarioLogado = Conexao.QueryFirstOrDefault<Usuario>(queryConsultaEmailSenha, new { recebeEmailUsuario = TextBox_Email.Text, recebeSenhaUsuario = TextBox_Senha.Text });

                if (usuarioLogado != null)
                {
                    MessageBox.Show("Credenciais válidas!",
                                     "SISTEMA DE SUPORTE",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
                    this.Close();
                    
                    if(usuarioLogado.tipoUsuario == "Cliente")
                    {
                        Thread_Cliente = new Thread(ChamaFormCliente);
                        Thread_Cliente.SetApartmentState(ApartmentState.STA);
                        Thread_Cliente.Start();
                    }else if(usuarioLogado.tipoUsuario == "Funcionário")
                    {
                        Thread_Funcionario = new Thread(ChamaFormFuncionario);
                        Thread_Funcionario.SetApartmentState(ApartmentState.STA);
                        Thread_Funcionario.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas!",
                                     "SISTEMA DE SUPORTE",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }
        }

        private void ChamaFormFuncionario()
        {
            Application.Run(new FormFuncionario());
        }

        private void ChamaFormCliente()
        {
            Application.Run(new FormCliente());
        }

        private void Button_Cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
