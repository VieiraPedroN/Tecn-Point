using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TecnPoint
{
    partial class FormTelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botaoEntrarLogin = new Button();
            EntradaEmail = new TextBox();
            EntradaSenha = new TextBox();
            EmailLogin = new Label();
            SenhaLogin = new Label();
            NomeEmpresa = new Label();
            DescricaoLogin = new Label();
            DescricaoSistema = new Label();
            SuspendLayout();
            // 
            // botaoEntrarLogin
            // 
            botaoEntrarLogin.Anchor = AnchorStyles.None;
            botaoEntrarLogin.BackColor = Color.FromArgb(126, 105, 171);
            botaoEntrarLogin.Cursor = Cursors.Hand;
            botaoEntrarLogin.FlatStyle = FlatStyle.Flat;
            botaoEntrarLogin.Font = new Font("Consolas", 11F);
            botaoEntrarLogin.ForeColor = SystemColors.ButtonHighlight;
            botaoEntrarLogin.Location = new Point(325, 327);
            botaoEntrarLogin.Name = "botaoEntrarLogin";
            botaoEntrarLogin.Size = new Size(150, 30);
            botaoEntrarLogin.TabIndex = 0;
            botaoEntrarLogin.Text = "Entrar";
            botaoEntrarLogin.UseVisualStyleBackColor = false;
            botaoEntrarLogin.Click += botaoEntrarLogin_Click;
            // 
            // EntradaEmail
            // 
            EntradaEmail.Anchor = AnchorStyles.None;
            EntradaEmail.Font = new Font("Consolas", 11F);
            EntradaEmail.Location = new Point(265, 195);
            EntradaEmail.Name = "EntradaEmail";
            EntradaEmail.PlaceholderText = "Digite seu e-mail";
            EntradaEmail.Size = new Size(270, 25);
            EntradaEmail.TabIndex = 1;
            // 
            // EntradaSenha
            // 
            EntradaSenha.Anchor = AnchorStyles.None;
            EntradaSenha.Cursor = Cursors.IBeam;
            EntradaSenha.Font = new Font("Consolas", 11F);
            EntradaSenha.Location = new Point(265, 274);
            EntradaSenha.Name = "EntradaSenha";
            EntradaSenha.PasswordChar = '*';
            EntradaSenha.PlaceholderText = "Digite sua senha";
            EntradaSenha.Size = new Size(270, 25);
            EntradaSenha.TabIndex = 2;
            // 
            // EmailLogin
            // 
            EmailLogin.Anchor = AnchorStyles.None;
            EmailLogin.AutoSize = true;
            EmailLogin.BackColor = Color.Transparent;
            EmailLogin.Font = new Font("Consolas", 13F);
            EmailLogin.Location = new Point(247, 165);
            EmailLogin.Name = "EmailLogin";
            EmailLogin.Size = new Size(60, 22);
            EmailLogin.TabIndex = 3;
            EmailLogin.Text = "Email";
            // 
            // SenhaLogin
            // 
            SenhaLogin.Anchor = AnchorStyles.None;
            SenhaLogin.AutoSize = true;
            SenhaLogin.BackColor = Color.Transparent;
            SenhaLogin.Font = new Font("Consolas", 13F);
            SenhaLogin.Location = new Point(247, 244);
            SenhaLogin.Name = "SenhaLogin";
            SenhaLogin.Size = new Size(60, 22);
            SenhaLogin.TabIndex = 4;
            SenhaLogin.Text = "Senha";
            // 
            // NomeEmpresa
            // 
            NomeEmpresa.Anchor = AnchorStyles.None;
            NomeEmpresa.AutoSize = true;
            NomeEmpresa.BackColor = Color.Transparent;
            NomeEmpresa.Font = new Font("Consolas", 30F, FontStyle.Bold);
            NomeEmpresa.Location = new Point(236, 66);
            NomeEmpresa.Name = "NomeEmpresa";
            NomeEmpresa.Size = new Size(328, 47);
            NomeEmpresa.TabIndex = 5;
            NomeEmpresa.Text = "Tech Solutions";
            // 
            // DescricaoLogin
            // 
            DescricaoLogin.Anchor = AnchorStyles.None;
            DescricaoLogin.AutoSize = true;
            DescricaoLogin.BackColor = Color.Transparent;
            DescricaoLogin.Font = new Font("Consolas", 10F);
            DescricaoLogin.ForeColor = SystemColors.ControlDarkDark;
            DescricaoLogin.Location = new Point(291, 123);
            DescricaoLogin.Name = "DescricaoLogin";
            DescricaoLogin.Size = new Size(216, 17);
            DescricaoLogin.TabIndex = 6;
            DescricaoLogin.Text = "Entre com suas credenciais";
            // 
            // DescricaoSistema
            // 
            DescricaoSistema.Anchor = AnchorStyles.None;
            DescricaoSistema.AutoSize = true;
            DescricaoSistema.BackColor = Color.Transparent;
            DescricaoSistema.Font = new Font("Consolas", 10F);
            DescricaoSistema.ForeColor = SystemColors.ControlDarkDark;
            DescricaoSistema.Location = new Point(280, 368);
            DescricaoSistema.Name = "DescricaoSistema";
            DescricaoSistema.Size = new Size(240, 17);
            DescricaoSistema.TabIndex = 7;
            DescricaoSistema.Text = "Sistema de Suporte ao Cliente";
            // 
            // FormTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = Interface.Properties.Resources.TelaFundoLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(DescricaoSistema);
            Controls.Add(DescricaoLogin);
            Controls.Add(NomeEmpresa);
            Controls.Add(SenhaLogin);
            Controls.Add(EmailLogin);
            Controls.Add(EntradaSenha);
            Controls.Add(EntradaEmail);
            Controls.Add(botaoEntrarLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoEntrarLogin;
        private TextBox EntradaEmail;
        private TextBox EntradaSenha;
        private Label EmailLogin;
        private Label SenhaLogin;
        private Label NomeEmpresa;
        private Label DescricaoLogin;
        private Label DescricaoSistema;
    }
}
