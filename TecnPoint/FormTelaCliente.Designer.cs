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
            btnCriarChamado = new Button();
            btnAcompanharChamado = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnChatBot = new Button();
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
            // btnCriarChamado
            // 
            btnCriarChamado.BackColor = Color.Transparent;
            btnCriarChamado.Cursor = Cursors.Hand;
            btnCriarChamado.FlatAppearance.BorderColor = Color.DarkGray;
            btnCriarChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnCriarChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnCriarChamado.FlatStyle = FlatStyle.Flat;
            btnCriarChamado.Font = new Font("Consolas", 11F);
            btnCriarChamado.ForeColor = Color.Gainsboro;
            btnCriarChamado.Image = Properties.Resources.PlusIconActive;
            btnCriarChamado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCriarChamado.Location = new Point(10, 111);
            btnCriarChamado.Name = "btnCriarChamado";
            btnCriarChamado.Size = new Size(232, 40);
            btnCriarChamado.TabIndex = 2;
            btnCriarChamado.Text = "Criar um chamado";
            btnCriarChamado.UseVisualStyleBackColor = false;
            btnCriarChamado.Click += botaoCriarChamado_Click;
            // 
            // btnAcompanharChamado
            // 
            btnAcompanharChamado.BackColor = Color.Transparent;
            btnAcompanharChamado.Cursor = Cursors.Hand;
            btnAcompanharChamado.FlatAppearance.BorderColor = Color.DarkGray;
            btnAcompanharChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnAcompanharChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnAcompanharChamado.FlatStyle = FlatStyle.Flat;
            btnAcompanharChamado.Font = new Font("Consolas", 11F);
            btnAcompanharChamado.ForeColor = Color.Gainsboro;
            btnAcompanharChamado.Image = Properties.Resources.ChecklistIconActive;
            btnAcompanharChamado.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcompanharChamado.Location = new Point(10, 158);
            btnAcompanharChamado.Name = "btnAcompanharChamado";
            btnAcompanharChamado.Size = new Size(232, 40);
            btnAcompanharChamado.TabIndex = 3;
            btnAcompanharChamado.Text = "Acompanhar um chamado";
            btnAcompanharChamado.TextAlign = ContentAlignment.MiddleRight;
            btnAcompanharChamado.UseVisualStyleBackColor = false;
            btnAcompanharChamado.Click += botaoAcompanharChamado_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(248, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 456);
            panel1.TabIndex = 4;
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
            // btnChatBot
            // 
            btnChatBot.BackColor = Color.Transparent;
            btnChatBot.Cursor = Cursors.Hand;
            btnChatBot.FlatAppearance.BorderColor = Color.DarkGray;
            btnChatBot.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnChatBot.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnChatBot.FlatStyle = FlatStyle.Flat;
            btnChatBot.Image = (Image)resources.GetObject("btnChatBot.Image");
            btnChatBot.Location = new Point(10, 398);
            btnChatBot.Name = "btnChatBot";
            btnChatBot.Size = new Size(45, 40);
            btnChatBot.TabIndex = 6;
            btnChatBot.UseVisualStyleBackColor = false;
            btnChatBot.Click += button1_Click;
            // 
            // FormTelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = Properties.Resources.TelaFundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChatBot);
            Controls.Add(btnAcompanharChamado);
            Controls.Add(btnCriarChamado);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(EmailUsuario);
            Controls.Add(NomeUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTelaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tecn Point";
            Closed += FormTelaCliente_Closed;
            Load += FormTelaCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeUsuario;
        private Label EmailUsuario;
        private Button btnCriarChamado;
        private Button btnAcompanharChamado;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnChatBot;
    }
}