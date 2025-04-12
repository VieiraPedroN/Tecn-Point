using TecnPoint.Dados;
using TecnPoint.Modelo.ClassLoginUsuario;
using TecnPoint.Modelo.ClassStaticUsuarioLogado;

namespace TecnPoint
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criando objeto para passar os dados para o usuário
            ClassRepositorioLoginUsuario dadosUsuarioLogado = new ClassRepositorioLoginUsuario();
            ClassLoginUsuario usuarioUsuarioLogado = new ClassLoginUsuario(idUsuario: 0, "", "", "", "");
            usuarioUsuarioLogado = dadosUsuarioLogado.ConsultaEmailSenha(email.Text, senha.Text);

            if(usuarioUsuarioLogado != null)
            {
                MessageBox.Show("Login válido",
                                "Tecn Solutions",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
