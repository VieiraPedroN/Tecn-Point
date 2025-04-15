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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaLogin));
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
            botaoEntrarLogin.ForeColor = Color.FromArgb(224, 224, 224);
            botaoEntrarLogin.Location = new Point(257, 240);
            botaoEntrarLogin.Name = "botaoEntrarLogin";
            botaoEntrarLogin.Size = new Size(185, 23);
            botaoEntrarLogin.TabIndex = 0;
            botaoEntrarLogin.Text = "Entrar";
            botaoEntrarLogin.UseVisualStyleBackColor = false;
            botaoEntrarLogin.Click += botaoEntrarLogin_Click;
            // 
            // EntradaEmail
            // 
            EntradaEmail.Anchor = AnchorStyles.None;
            EntradaEmail.Location = new Point(230, 141);
            EntradaEmail.Name = "EntradaEmail";
            EntradaEmail.Size = new Size(240, 23);
            EntradaEmail.TabIndex = 1;
            // 
            // EntradaSenha
            // 
            EntradaSenha.Anchor = AnchorStyles.None;
            EntradaSenha.Cursor = Cursors.IBeam;
            EntradaSenha.Location = new Point(230, 191);
            EntradaSenha.Name = "EntradaSenha";
            EntradaSenha.PasswordChar = '*';
            EntradaSenha.Size = new Size(240, 23);
            EntradaSenha.TabIndex = 2;
            // 
            // EmailLogin
            // 
            EmailLogin.Anchor = AnchorStyles.None;
            EmailLogin.AutoSize = true;
            EmailLogin.BackColor = Color.Transparent;
            EmailLogin.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLogin.Location = new Point(215, 120);
            EmailLogin.Name = "EmailLogin";
            EmailLogin.Size = new Size(55, 18);
            EmailLogin.TabIndex = 3;
            EmailLogin.Text = "Email";
            // 
            // SenhaLogin
            // 
            SenhaLogin.Anchor = AnchorStyles.None;
            SenhaLogin.AutoSize = true;
            SenhaLogin.BackColor = Color.Transparent;
            SenhaLogin.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SenhaLogin.Location = new Point(215, 170);
            SenhaLogin.Name = "SenhaLogin";
            SenhaLogin.Size = new Size(50, 18);
            SenhaLogin.TabIndex = 4;
            SenhaLogin.Text = "Senha";
            // 
            // NomeEmpresa
            // 
            NomeEmpresa.Anchor = AnchorStyles.None;
            NomeEmpresa.AutoSize = true;
            NomeEmpresa.BackColor = Color.Transparent;
            NomeEmpresa.Font = new Font("Berlin Sans FB Demi", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomeEmpresa.Location = new Point(263, 50);
            NomeEmpresa.Name = "NomeEmpresa";
            NomeEmpresa.Size = new Size(179, 31);
            NomeEmpresa.TabIndex = 5;
            NomeEmpresa.Text = "Tech Solutions";
            // 
            // DescricaoLogin
            // 
            DescricaoLogin.Anchor = AnchorStyles.None;
            DescricaoLogin.AutoSize = true;
            DescricaoLogin.BackColor = Color.Transparent;
            DescricaoLogin.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescricaoLogin.Location = new Point(280, 83);
            DescricaoLogin.Name = "DescricaoLogin";
            DescricaoLogin.Size = new Size(139, 13);
            DescricaoLogin.TabIndex = 6;
            DescricaoLogin.Text = "Entre com suas credenciais";
            // 
            // DescricaoSistema
            // 
            DescricaoSistema.Anchor = AnchorStyles.None;
            DescricaoSistema.AutoSize = true;
            DescricaoSistema.BackColor = Color.Transparent;
            DescricaoSistema.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescricaoSistema.Location = new Point(270, 275);
            DescricaoSistema.Name = "DescricaoSistema";
            DescricaoSistema.Size = new Size(157, 13);
            DescricaoSistema.TabIndex = 7;
            DescricaoSistema.Text = "Sistema de Suporte ao Cliente";
            // 
            // FormTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(DescricaoSistema);
            Controls.Add(DescricaoLogin);
            Controls.Add(NomeEmpresa);
            Controls.Add(SenhaLogin);
            Controls.Add(EmailLogin);
            Controls.Add(EntradaSenha);
            Controls.Add(EntradaEmail);
            Controls.Add(botaoEntrarLogin);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTelaLogin";
            Text = "Form1";
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
