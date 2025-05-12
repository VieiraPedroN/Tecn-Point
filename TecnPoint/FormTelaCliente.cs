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
        private readonly bool _modoDaltonico;
        private ModeloUsuario usuarioLogado;
        public FormTelaCliente(ModeloUsuario dadosUsuario, bool modoDaltonico)
        {
            this.usuarioLogado = dadosUsuario;
            InitializeComponent();
            _modoDaltonico = modoDaltonico;
            ModoDaltonismo();
        }
        private void CarregarFormularioForm(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }
        private void FormTelaCliente_Closed(object sender, EventArgs e)
        {
            FormTelaLogin telaLogin = new FormTelaLogin();
            telaLogin.DefinirModoDaltonico(_modoDaltonico);
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
            CarregarFormularioForm(new FormTelaCadastroChamado(usuarioLogado, this, _modoDaltonico));

        }
        public void botaoAcompanharChamado_Click(object sender, EventArgs e)
        {
            CarregarFormularioForm(new FormTelaAcompanharChamado(usuarioLogado, _modoDaltonico));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTelaChatbot telachatbot = new FormTelaChatbot(this, _modoDaltonico);
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


            Logo.Image = Properties.Resources._02051eac_c113_448e_b8ec_e26d1461e356;
            Logo.Location = new Point(145, 52);
            Logo.Name = "pictureBox1";
            Logo.Size = new Size(262, 217);
            Logo.TabIndex = 0;
            Logo.TabStop = false;

            panel1.Controls.Add(lblTituloTelaInicioCliente);
            panel1.Controls.Add(lblSubtituloTelaInicialCliente);
            panel1.Controls.Add(Logo);
        }
        private void ModoDaltonismo()
        {
            if (_modoDaltonico)
            {
                this.BackgroundImage = Interface.Properties.Resources.Rectangle_34_Daltonico;

                btnCriarChamado.BackColor = Color.Transparent;
                btnCriarChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 190, 137);
                btnCriarChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 163, 89);

               

                btnAcompanharChamado.BackColor = Color.Transparent;
                btnAcompanharChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 190, 137);
                btnAcompanharChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 163, 89);
                

                btnChatBot.BackColor = Color.Transparent;
                btnChatBot.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 190, 137);
                btnChatBot.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 163, 89);
                
                
            }
            else
            {
                this.BackgroundImage = Interface.Properties.Resources.TelaFundo;

                btnCriarChamado.BackColor = Color.Transparent;
                btnCriarChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
                btnCriarChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
                btnCriarChamado.Click += (sender, e) =>
                

                btnAcompanharChamado.BackColor = Color.Transparent;
                btnAcompanharChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
                btnAcompanharChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);

                

                btnChatBot.BackColor = Color.Transparent;
                btnChatBot.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
                btnChatBot.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            }
        }
    }

}
