namespace TecnPoint.Interface
{
    partial class FormTelaCadastroUser
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
            components = new System.ComponentModel.Container();
            txtbNome = new TextBox();
            txtbEmail = new TextBox();
            txtbSenha = new TextBox();
            btnCadastrar = new Button();
            lblTituloNovoUsuario = new Label();
            btnCancelarCadastro = new Button();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblTipoUsuario = new Label();
            cbbTipoUsuário = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtbNome
            // 
            txtbNome.Location = new Point(157, 79);
            txtbNome.Name = "txtbNome";
            txtbNome.Size = new Size(198, 23);
            txtbNome.TabIndex = 0;
            txtbNome.Leave += txtbNome_Leave;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(157, 129);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(198, 23);
            txtbEmail.TabIndex = 1;
            txtbEmail.Leave += txtbEmail_Leave;
            // 
            // txtbSenha
            // 
            txtbSenha.Location = new Point(157, 179);
            txtbSenha.Name = "txtbSenha";
            txtbSenha.Size = new Size(198, 23);
            txtbSenha.TabIndex = 2;
            txtbSenha.Leave += txtbSenha_Leave;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(126, 105, 171);
            btnCadastrar.FlatAppearance.BorderColor = Color.DarkGray;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Location = new Point(280, 279);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblTituloNovoUsuario
            // 
            lblTituloNovoUsuario.AutoSize = true;
            lblTituloNovoUsuario.BackColor = Color.Transparent;
            lblTituloNovoUsuario.Font = new Font("Consolas", 25F, FontStyle.Bold);
            lblTituloNovoUsuario.Location = new Point(12, 9);
            lblTituloNovoUsuario.Name = "lblTituloNovoUsuario";
            lblTituloNovoUsuario.Size = new Size(245, 40);
            lblTituloNovoUsuario.TabIndex = 6;
            lblTituloNovoUsuario.Text = "Novo Usuário";
            // 
            // btnCancelarCadastro
            // 
            btnCancelarCadastro.BackColor = SystemColors.ButtonFace;
            btnCancelarCadastro.FlatAppearance.BorderColor = Color.DarkGray;
            btnCancelarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnCancelarCadastro.FlatStyle = FlatStyle.Flat;
            btnCancelarCadastro.ForeColor = Color.Gray;
            btnCancelarCadastro.Location = new Point(157, 279);
            btnCancelarCadastro.Name = "btnCancelarCadastro";
            btnCancelarCadastro.Size = new Size(75, 23);
            btnCancelarCadastro.TabIndex = 4;
            btnCancelarCadastro.Text = "Cancelar";
            btnCancelarCadastro.UseVisualStyleBackColor = false;
            btnCancelarCadastro.Click += btnCancelarCadastro_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblNome.Location = new Point(111, 84);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 18);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblEmail.Location = new Point(95, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 18);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblSenha.Location = new Point(103, 184);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(48, 18);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.BackColor = Color.Transparent;
            lblTipoUsuario.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblTipoUsuario.Location = new Point(23, 230);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(128, 18);
            lblTipoUsuario.TabIndex = 10;
            lblTipoUsuario.Text = "Tipo de Usuário";
            // 
            // cbbTipoUsuário
            // 
            cbbTipoUsuário.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoUsuário.FormattingEnabled = true;
            cbbTipoUsuário.Items.AddRange(new object[] { "Funcionário", "Cliente" });
            cbbTipoUsuário.Location = new Point(157, 229);
            cbbTipoUsuário.Name = "cbbTipoUsuário";
            cbbTipoUsuário.Size = new Size(198, 23);
            cbbTipoUsuário.TabIndex = 3;
            cbbTipoUsuário.Leave += cbbTipoUsuário_Leave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormTelaCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(480, 345);
            Controls.Add(cbbTipoUsuário);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(btnCancelarCadastro);
            Controls.Add(lblTituloNovoUsuario);
            Controls.Add(btnCadastrar);
            Controls.Add(txtbSenha);
            Controls.Add(txtbEmail);
            Controls.Add(txtbNome);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTelaCadastroUser";
            Text = "FormTelaCadastroUser";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbNome;
        private TextBox txtbEmail;
        private TextBox txtbSenha;
        private ComboBox cbbTipoUsuário;
        private Button btnCadastrar;
        private Button btnCancelarCadastro;
        private Label lblTituloNovoUsuario;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblTipoUsuario;
        private ErrorProvider errorProvider1;
    }
}