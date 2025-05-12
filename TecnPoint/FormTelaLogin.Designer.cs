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
            EntradaEmail = new TextBox();
            EntradaSenha = new TextBox();
            EmailLogin = new Label();
            SenhaLogin = new Label();
            NomeEmpresa = new Label();
            DescricaoLogin = new Label();
            DescricaoSistema = new Label();
            label1 = new Label();
            btnEntrarLogin = new Button();
            chcbModoDaltonico = new CheckBox();
            SuspendLayout();
            // 
            // EntradaEmail
            // 
            EntradaEmail.Anchor = AnchorStyles.None;
            EntradaEmail.Font = new Font("Consolas", 11F);
            EntradaEmail.Location = new Point(265, 195);
            EntradaEmail.Name = "EntradaEmail";
            EntradaEmail.PlaceholderText = "Digite seu e-mail";
            EntradaEmail.Size = new Size(270, 25);
            EntradaEmail.TabIndex = 0;
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
            EntradaSenha.TabIndex = 1;
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
            EmailLogin.TabIndex = 6;
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
            SenhaLogin.TabIndex = 7;
            SenhaLogin.Text = "Senha";
            // 
            // NomeEmpresa
            // 
            NomeEmpresa.Anchor = AnchorStyles.None;
            NomeEmpresa.AutoSize = true;
            NomeEmpresa.BackColor = Color.Transparent;
            NomeEmpresa.Font = new Font("Consolas", 30F, FontStyle.Bold);
            NomeEmpresa.Location = new Point(235, 75);
            NomeEmpresa.Name = "NomeEmpresa";
            NomeEmpresa.Size = new Size(328, 47);
            NomeEmpresa.TabIndex = 4;
            NomeEmpresa.Text = "Lar dos Sonhos";
            // 
            // DescricaoLogin
            // 
            DescricaoLogin.Anchor = AnchorStyles.None;
            DescricaoLogin.AutoSize = true;
            DescricaoLogin.BackColor = Color.Transparent;
            DescricaoLogin.Font = new Font("Consolas", 10F);
            DescricaoLogin.ForeColor = SystemColors.ControlDarkDark;
            DescricaoLogin.Location = new Point(295, 131);
            DescricaoLogin.Name = "DescricaoLogin";
            DescricaoLogin.Size = new Size(216, 17);
            DescricaoLogin.TabIndex = 5;
            DescricaoLogin.Text = "Entre com suas credenciais";
            // 
            // DescricaoSistema
            // 
            DescricaoSistema.Anchor = AnchorStyles.None;
            DescricaoSistema.AutoSize = true;
            DescricaoSistema.BackColor = Color.Transparent;
            DescricaoSistema.Font = new Font("Consolas", 10F);
            DescricaoSistema.ForeColor = SystemColors.ControlDarkDark;
            DescricaoSistema.Location = new Point(280, 361);
            DescricaoSistema.Name = "DescricaoSistema";
            DescricaoSistema.Size = new Size(240, 17);
            DescricaoSistema.TabIndex = 8;
            DescricaoSistema.Text = "Sistema de Suporte ao Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 8F);
            label1.Location = new Point(318, 382);
            label1.Name = "label1";
            label1.Size = new Size(157, 13);
            label1.TabIndex = 9;
            label1.Text = "Criado por Tech Solutions";
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Anchor = AnchorStyles.None;
            btnEntrarLogin.BackColor = Color.FromArgb(126, 105, 171);
            btnEntrarLogin.Cursor = Cursors.Hand;
            btnEntrarLogin.FlatStyle = FlatStyle.Flat;
            btnEntrarLogin.Font = new Font("Consolas", 11F);
            btnEntrarLogin.ForeColor = SystemColors.ButtonHighlight;
            btnEntrarLogin.Location = new Point(325, 319);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(150, 30);
            btnEntrarLogin.TabIndex = 2;
            btnEntrarLogin.Text = "Entrar";
            btnEntrarLogin.UseVisualStyleBackColor = false;
            btnEntrarLogin.Click += botaoEntrarLogin_Click;
            // 
            // chcbModoDaltonico
            // 
            chcbModoDaltonico.AutoSize = true;
            chcbModoDaltonico.BackColor = Color.Transparent;
            chcbModoDaltonico.Font = new Font("Segoe UI", 10F);
            chcbModoDaltonico.ForeColor = Color.LightGray;
            chcbModoDaltonico.Location = new Point(12, 415);
            chcbModoDaltonico.Name = "chcbModoDaltonico";
            chcbModoDaltonico.Size = new Size(127, 23);
            chcbModoDaltonico.TabIndex = 3;
            chcbModoDaltonico.Text = "Modo Daltonico";
            chcbModoDaltonico.UseVisualStyleBackColor = false;
            chcbModoDaltonico.CheckedChanged += chcbModoDaltonico_CheckedChanged;
            // 
            // FormTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = Interface.Properties.Resources.TelaFundoLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(chcbModoDaltonico);
            Controls.Add(label1);
            Controls.Add(DescricaoSistema);
            Controls.Add(DescricaoLogin);
            Controls.Add(NomeEmpresa);
            Controls.Add(SenhaLogin);
            Controls.Add(EmailLogin);
            Controls.Add(EntradaSenha);
            Controls.Add(EntradaEmail);
            Controls.Add(btnEntrarLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tecn Point";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox EntradaEmail;
        private TextBox EntradaSenha;
        private Label EmailLogin;
        private Label SenhaLogin;
        private Label NomeEmpresa;
        private Label DescricaoLogin;
        private Label DescricaoSistema;
        private Label label1;
        private Button btnEntrarLogin;
        private CheckBox chcbModoDaltonico;
    }
}
