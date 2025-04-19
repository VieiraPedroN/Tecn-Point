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
            txtbNome = new TextBox();
            txtbEmail = new TextBox();
            txtbSenha = new TextBox();
            txtbTipoUsuario = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            btnCancelarCadastro = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtbNome
            // 
            txtbNome.Location = new Point(260, 62);
            txtbNome.Name = "txtbNome";
            txtbNome.Size = new Size(198, 23);
            txtbNome.TabIndex = 0;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(260, 112);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(198, 23);
            txtbEmail.TabIndex = 1;
            // 
            // txtbSenha
            // 
            txtbSenha.Location = new Point(260, 162);
            txtbSenha.Name = "txtbSenha";
            txtbSenha.Size = new Size(198, 23);
            txtbSenha.TabIndex = 2;
            // 
            // txtbTipoUsuario
            // 
            txtbTipoUsuario.Location = new Point(260, 212);
            txtbTipoUsuario.Name = "txtbTipoUsuario";
            txtbTipoUsuario.Size = new Size(198, 23);
            txtbTipoUsuario.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatAppearance.BorderColor = Color.DarkGray;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = Color.Gainsboro;
            btnCadastrar.Location = new Point(383, 262);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB Demi", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 5;
            label1.Text = "Novo Usuário";
            // 
            // btnCancelarCadastro
            // 
            btnCancelarCadastro.FlatAppearance.BorderColor = Color.DarkGray;
            btnCancelarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnCancelarCadastro.FlatStyle = FlatStyle.Flat;
            btnCancelarCadastro.ForeColor = Color.Gainsboro;
            btnCancelarCadastro.Location = new Point(260, 262);
            btnCancelarCadastro.Name = "btnCancelarCadastro";
            btnCancelarCadastro.Size = new Size(75, 23);
            btnCancelarCadastro.TabIndex = 6;
            btnCancelarCadastro.Text = "Cancelar";
            btnCancelarCadastro.UseVisualStyleBackColor = true;
            btnCancelarCadastro.Click += btnCancelarCadastro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 12F);
            label2.Location = new Point(206, 67);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Berlin Sans FB", 12F);
            label3.Location = new Point(203, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 8;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Berlin Sans FB", 12F);
            label4.Location = new Point(206, 167);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 9;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(144, 217);
            label5.Name = "label5";
            label5.Size = new Size(110, 18);
            label5.TabIndex = 10;
            label5.Text = "Tipo de Usuário";
            // 
            // FormTelaCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = Properties.Resources.TelaFundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelarCadastro);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtbTipoUsuario);
            Controls.Add(txtbSenha);
            Controls.Add(txtbEmail);
            Controls.Add(txtbNome);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Name = "FormTelaCadastroUser";
            Text = "FormTelaCadastroUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbNome;
        private TextBox txtbEmail;
        private TextBox txtbSenha;
        private TextBox txtbTipoUsuario;
        private Button btnCadastrar;
        private Label label1;
        private Button btnCancelarCadastro;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}