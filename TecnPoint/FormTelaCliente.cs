using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Modelo;


namespace TecnPoint.Interface
{
    public partial class FormTelaCliente : Form
    {
        private ModeloUsuario usuarioLogado;
        public FormTelaCliente(ModeloUsuario dadosUsuario)
        {
            this.usuarioLogado = dadosUsuario;
            InitializeComponent();
        }
        private void CarregarFormularioForm(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
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
            NomeUsuario.Text = usuarioLogado.Nome;
            EmailUsuario.Text = usuarioLogado.Email;
            CarregarTelaInicio();
        }
        public void botaoCriarChamado_Click(object sender, EventArgs e)
        {
            AlternarBotoes(botaoCriarChamado, botaoAcompanharChamado);
            CarregarFormularioForm(new FormTelaCadastroChamado(usuarioLogado, this));

        }
        public void botaoAcompanharChamado_Click(object sender, EventArgs e)
        {
            AlternarBotoes(botaoAcompanharChamado, botaoCriarChamado);
            CarregarFormularioForm(new FormTelaAcompanharChamado(usuarioLogado));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTelaChatbot telachatbot = new FormTelaChatbot(this);
            telachatbot.ShowDialog();
        }

        public void CarregarTelaInicio()
        {
            panel1.Controls.Clear();

            Label lblTituloTelaInicioCliente = new Label();
            Label lblSubtituloTelaInicialCliente = new Label();
            PictureBox Logo = new PictureBox();

            lblTituloTelaInicioCliente.AutoSize = true;
            lblTituloTelaInicioCliente.Font = new Font("Consolas", 32F, FontStyle.Bold);
            lblTituloTelaInicioCliente.Location = new Point(100, 281);
            lblTituloTelaInicioCliente.Name = "lblTituloTelaInicioCliente";
            lblTituloTelaInicioCliente.Size = new Size(358, 51);
            lblTituloTelaInicioCliente.TabIndex = 0;
            lblTituloTelaInicioCliente.Text = "Tech Solutions";

            lblSubtituloTelaInicialCliente.AutoSize = true;
            lblSubtituloTelaInicialCliente.Font = new Font("Consolas", 8F);
            lblSubtituloTelaInicialCliente.Location = new Point(130, 332);
            lblSubtituloTelaInicialCliente.Name = "lblSubtituloTelaInicialCliente";
            lblSubtituloTelaInicialCliente.Size = new Size(295, 13);
            lblSubtituloTelaInicialCliente.TabIndex = 1;
            lblSubtituloTelaInicialCliente.Text = "Unidos pelo desafio, moldados pelo conhecimento.";


            Logo.Image = Properties.Resources.WhatsApp_Image_2025_05_11_at_22_09_06_removebg_preview__1_;
            Logo.Location = new Point(145, 52);
            Logo.Name = "pictureBox1";
            Logo.Size = new Size(262, 217);
            Logo.TabIndex = 0;
            Logo.TabStop = false;

            panel1.Controls.Add(lblTituloTelaInicioCliente);
            panel1.Controls.Add(lblSubtituloTelaInicialCliente);
            panel1.Controls.Add(Logo);
        }
    }

}
