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
            SuspendLayout();
            // 
            // txtbNome
            // 
            txtbNome.Location = new Point(305, 50);
            txtbNome.Name = "txtbNome";
            txtbNome.Size = new Size(100, 23);
            txtbNome.TabIndex = 0;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(305, 100);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(100, 23);
            txtbEmail.TabIndex = 1;
            // 
            // txtbSenha
            // 
            txtbSenha.Location = new Point(305, 150);
            txtbSenha.Name = "txtbSenha";
            txtbSenha.Size = new Size(100, 23);
            txtbSenha.TabIndex = 2;
            // 
            // txtbTipoUsuario
            // 
            txtbTipoUsuario.Location = new Point(305, 200);
            txtbTipoUsuario.Name = "txtbTipoUsuario";
            txtbTipoUsuario.Size = new Size(100, 23);
            txtbTipoUsuario.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(305, 250);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormTelaCadastroUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCadastrar);
            Controls.Add(txtbTipoUsuario);
            Controls.Add(txtbSenha);
            Controls.Add(txtbEmail);
            Controls.Add(txtbNome);
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
    }
}