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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaCadastroUser));
            txtbNome = new TextBox();
            txtbEmail = new TextBox();
            txtbSenha = new TextBox();
            btnCadastrar = new Button();
            btnCancelarCadastro = new Button();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblTipoUsuario = new Label();
            cbbTipoUsuário = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            lblInfoEmail = new Label();
            lblExclamacao = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtbNome
            // 
            txtbNome.Cursor = Cursors.IBeam;
            txtbNome.Font = new Font("Segoe UI", 11F);
            txtbNome.Location = new Point(140, 76);
            txtbNome.Name = "txtbNome";
            txtbNome.PlaceholderText = "Insira o nome";
            txtbNome.Size = new Size(300, 27);
            txtbNome.TabIndex = 0;
            txtbNome.Leave += txtbNome_Leave;
            // 
            // txtbEmail
            // 
            txtbEmail.Cursor = Cursors.IBeam;
            txtbEmail.Font = new Font("Segoe UI", 11F);
            txtbEmail.Location = new Point(140, 157);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.PlaceholderText = "Insira o e-mail";
            txtbEmail.Size = new Size(300, 27);
            txtbEmail.TabIndex = 1;
            txtbEmail.Leave += txtbEmail_Leave;
            // 
            // txtbSenha
            // 
            txtbSenha.Cursor = Cursors.IBeam;
            txtbSenha.Font = new Font("Segoe UI", 11F);
            txtbSenha.Location = new Point(140, 238);
            txtbSenha.Name = "txtbSenha";
            txtbSenha.PlaceholderText = "Insira a senha";
            txtbSenha.Size = new Size(300, 27);
            txtbSenha.TabIndex = 2;
            txtbSenha.Leave += txtbSenha_Leave;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(126, 105, 171);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderColor = Color.DarkGray;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Consolas", 11.25F);
            btnCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnCadastrar.Location = new Point(330, 403);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(110, 30);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelarCadastro
            // 
            btnCancelarCadastro.BackColor = SystemColors.ButtonFace;
            btnCancelarCadastro.Cursor = Cursors.Hand;
            btnCancelarCadastro.FlatAppearance.BorderColor = Color.DarkGray;
            btnCancelarCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnCancelarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnCancelarCadastro.FlatStyle = FlatStyle.Flat;
            btnCancelarCadastro.Font = new Font("Consolas", 11.25F);
            btnCancelarCadastro.ForeColor = Color.DimGray;
            btnCancelarCadastro.Location = new Point(140, 403);
            btnCancelarCadastro.Name = "btnCancelarCadastro";
            btnCancelarCadastro.Size = new Size(110, 30);
            btnCancelarCadastro.TabIndex = 4;
            btnCancelarCadastro.Text = "Cancelar";
            btnCancelarCadastro.UseVisualStyleBackColor = false;
            btnCancelarCadastro.Click += btnCancelarCadastro_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Consolas", 13F);
            lblNome.Location = new Point(114, 38);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 22);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Consolas", 13F);
            lblEmail.Location = new Point(114, 119);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 22);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Consolas", 13F);
            lblSenha.Location = new Point(114, 200);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 22);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.BackColor = Color.Transparent;
            lblTipoUsuario.Font = new Font("Consolas", 13F);
            lblTipoUsuario.Location = new Point(114, 281);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(160, 22);
            lblTipoUsuario.TabIndex = 10;
            lblTipoUsuario.Text = "Tipo de Usuário";
            // 
            // cbbTipoUsuário
            // 
            cbbTipoUsuário.Cursor = Cursors.Hand;
            cbbTipoUsuário.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoUsuário.Font = new Font("Segoe UI", 11F);
            cbbTipoUsuário.FormattingEnabled = true;
            cbbTipoUsuário.Items.AddRange(new object[] { "Funcionário", "Cliente" });
            cbbTipoUsuário.Location = new Point(140, 319);
            cbbTipoUsuário.Name = "cbbTipoUsuário";
            cbbTipoUsuário.Size = new Size(300, 28);
            cbbTipoUsuário.TabIndex = 3;
            cbbTipoUsuário.Leave += cbbTipoUsuário_Leave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblInfoEmail
            // 
            lblInfoEmail.AutoSize = true;
            lblInfoEmail.BackColor = Color.Transparent;
            lblInfoEmail.FlatStyle = FlatStyle.Flat;
            lblInfoEmail.Font = new Font("Consolas", 8F);
            lblInfoEmail.ForeColor = SystemColors.ControlText;
            lblInfoEmail.Location = new Point(203, 124);
            lblInfoEmail.Name = "lblInfoEmail";
            lblInfoEmail.Size = new Size(247, 13);
            lblInfoEmail.TabIndex = 11;
            lblInfoEmail.Text = "Os caracteres '@' e '.' são obrigatórios";
            lblInfoEmail.Visible = false;
            // 
            // lblExclamacao
            // 
            lblExclamacao.AutoSize = true;
            lblExclamacao.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblExclamacao.ForeColor = Color.Red;
            lblExclamacao.Location = new Point(446, 121);
            lblExclamacao.Name = "lblExclamacao";
            lblExclamacao.Size = new Size(16, 18);
            lblExclamacao.TabIndex = 13;
            lblExclamacao.Text = "!";
            lblExclamacao.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 19);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormTelaCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(555, 460);
            Controls.Add(pictureBox1);
            Controls.Add(lblExclamacao);
            Controls.Add(lblInfoEmail);
            Controls.Add(cbbTipoUsuário);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(btnCancelarCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(txtbSenha);
            Controls.Add(txtbEmail);
            Controls.Add(txtbNome);
            Cursor = Cursors.Arrow;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTelaCadastroUser";
            Text = "FormTelaCadastroUser";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblTipoUsuario;
        private ErrorProvider errorProvider1;
        private Label lblInfoEmail;
        private Label lblExclamacao;
        private PictureBox pictureBox1;
    }
}