namespace TecnPoint.Interface
{
    partial class FormTelaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaCliente));
            NomeUsuario = new Label();
            EmailUsuario = new Label();
            botaoCriarChamado = new Button();
            botaoAcompanharChamado = new Button();
            panel1 = new Panel();
            lblSubtituloTelaInicialCliente = new Label();
            lblTituloTelaInicioCliente = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NomeUsuario
            // 
            NomeUsuario.AutoSize = true;
            NomeUsuario.BackColor = Color.Transparent;
            NomeUsuario.Font = new Font("Consolas", 10F);
            NomeUsuario.ForeColor = Color.Gainsboro;
            NomeUsuario.Location = new Point(80, 23);
            NomeUsuario.Name = "NomeUsuario";
            NomeUsuario.Size = new Size(104, 17);
            NomeUsuario.TabIndex = 0;
            NomeUsuario.Text = "Nome Usuario";
            // 
            // EmailUsuario
            // 
            EmailUsuario.AutoSize = true;
            EmailUsuario.BackColor = Color.Transparent;
            EmailUsuario.Font = new Font("Consolas", 10F);
            EmailUsuario.ForeColor = Color.Gainsboro;
            EmailUsuario.Location = new Point(80, 48);
            EmailUsuario.Name = "EmailUsuario";
            EmailUsuario.Size = new Size(112, 17);
            EmailUsuario.TabIndex = 1;
            EmailUsuario.Text = "Email Usuario";
            // 
            // botaoCriarChamado
            // 
            botaoCriarChamado.BackColor = Color.Transparent;
            botaoCriarChamado.Cursor = Cursors.Hand;
            botaoCriarChamado.FlatAppearance.BorderColor = Color.DarkGray;
            botaoCriarChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            botaoCriarChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            botaoCriarChamado.FlatStyle = FlatStyle.Flat;
            botaoCriarChamado.Font = new Font("Consolas", 11F);
            botaoCriarChamado.ForeColor = Color.Gainsboro;
            botaoCriarChamado.Image = Properties.Resources.PlusIconActive;
            botaoCriarChamado.ImageAlign = ContentAlignment.MiddleLeft;
            botaoCriarChamado.Location = new Point(10, 111);
            botaoCriarChamado.Name = "botaoCriarChamado";
            botaoCriarChamado.Size = new Size(232, 40);
            botaoCriarChamado.TabIndex = 2;
            botaoCriarChamado.Text = "Criar um chamado";
            botaoCriarChamado.UseVisualStyleBackColor = false;
            botaoCriarChamado.Click += botaoCriarChamado_Click;
            // 
            // botaoAcompanharChamado
            // 
            botaoAcompanharChamado.BackColor = Color.Transparent;
            botaoAcompanharChamado.Cursor = Cursors.Hand;
            botaoAcompanharChamado.FlatAppearance.BorderColor = Color.DarkGray;
            botaoAcompanharChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            botaoAcompanharChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            botaoAcompanharChamado.FlatStyle = FlatStyle.Flat;
            botaoAcompanharChamado.Font = new Font("Consolas", 11F);
            botaoAcompanharChamado.ForeColor = Color.Gainsboro;
            botaoAcompanharChamado.Image = Properties.Resources.ChecklistIconActive;
            botaoAcompanharChamado.ImageAlign = ContentAlignment.MiddleLeft;
            botaoAcompanharChamado.Location = new Point(10, 158);
            botaoAcompanharChamado.Name = "botaoAcompanharChamado";
            botaoAcompanharChamado.Size = new Size(232, 40);
            botaoAcompanharChamado.TabIndex = 3;
            botaoAcompanharChamado.Text = "Acompanhar um chamado";
            botaoAcompanharChamado.TextAlign = ContentAlignment.MiddleRight;
            botaoAcompanharChamado.UseVisualStyleBackColor = false;
            botaoAcompanharChamado.Click += botaoAcompanharChamado_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblSubtituloTelaInicialCliente);
            panel1.Controls.Add(lblTituloTelaInicioCliente);
            panel1.Location = new Point(248, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 456);
            panel1.TabIndex = 4;
            // 
            // lblSubtituloTelaInicialCliente
            // 
            lblSubtituloTelaInicialCliente.AutoSize = true;
            lblSubtituloTelaInicialCliente.Font = new Font("Consolas", 8F);
            lblSubtituloTelaInicialCliente.Location = new Point(146, 332);
            lblSubtituloTelaInicialCliente.Name = "lblSubtituloTelaInicialCliente";
            lblSubtituloTelaInicialCliente.Size = new Size(295, 13);
            lblSubtituloTelaInicialCliente.TabIndex = 1;
            lblSubtituloTelaInicialCliente.Text = "Unidos pelo desafio, moldados pelo conhecimento.";
            // 
            // lblTituloTelaInicioCliente
            // 
            lblTituloTelaInicioCliente.AutoSize = true;
            lblTituloTelaInicioCliente.Font = new Font("Consolas", 32F, FontStyle.Bold);
            lblTituloTelaInicioCliente.Location = new Point(116, 281);
            lblTituloTelaInicioCliente.Name = "lblTituloTelaInicioCliente";
            lblTituloTelaInicioCliente.Size = new Size(358, 51);
            lblTituloTelaInicioCliente.TabIndex = 0;
            lblTituloTelaInicioCliente.Text = "Tech Solutions";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.UserPicture;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(70, 79);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DarkGray;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(10, 398);
            button1.Name = "button1";
            button1.Size = new Size(45, 40);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormTelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(botaoAcompanharChamado);
            Controls.Add(botaoCriarChamado);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(EmailUsuario);
            Controls.Add(NomeUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTelaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTelaCliente";
            Closed += FormTelaCliente_Closed;
            Load += FormTelaCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeUsuario;
        private Label EmailUsuario;
        private Button botaoCriarChamado;
        private Button botaoAcompanharChamado;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button button1;
        private Label lblTituloTelaInicioCliente;
        private Label lblSubtituloTelaInicialCliente;
    }
}