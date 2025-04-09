namespace FormLogin
{
    partial class FormLog
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
            panel1 = new Panel();
            Button_Cancela = new Button();
            Button_Entrar = new Button();
            Label_Senha = new Label();
            TextBox_Senha = new TextBox();
            TextBox_Email = new TextBox();
            Label_Email = new Label();
            Label_Semi_Titulo = new Label();
            Label_Sistema_Suporte = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Button_Cancela);
            panel1.Controls.Add(Button_Entrar);
            panel1.Controls.Add(Label_Senha);
            panel1.Controls.Add(TextBox_Senha);
            panel1.Controls.Add(TextBox_Email);
            panel1.Controls.Add(Label_Email);
            panel1.Controls.Add(Label_Semi_Titulo);
            panel1.Controls.Add(Label_Sistema_Suporte);
            panel1.Location = new Point(210, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 322);
            panel1.TabIndex = 0;
            // 
            // Button_Cancela
            // 
            Button_Cancela.BackColor = Color.BlueViolet;
            Button_Cancela.FlatAppearance.MouseOverBackColor = Color.White;
            Button_Cancela.FlatStyle = FlatStyle.Popup;
            Button_Cancela.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Cancela.ForeColor = Color.White;
            Button_Cancela.Location = new Point(57, 224);
            Button_Cancela.Name = "Button_Cancela";
            Button_Cancela.Size = new Size(272, 23);
            Button_Cancela.TabIndex = 7;
            Button_Cancela.Text = "Cancelar";
            Button_Cancela.UseVisualStyleBackColor = false;
            Button_Cancela.Click += Button_Cancela_Click;
            // 
            // Button_Entrar
            // 
            Button_Entrar.BackColor = Color.BlueViolet;
            Button_Entrar.FlatAppearance.MouseOverBackColor = Color.Purple;
            Button_Entrar.FlatStyle = FlatStyle.Popup;
            Button_Entrar.Font = new Font("Arial", 9F, FontStyle.Bold);
            Button_Entrar.ForeColor = Color.White;
            Button_Entrar.Location = new Point(57, 253);
            Button_Entrar.Name = "Button_Entrar";
            Button_Entrar.Size = new Size(274, 23);
            Button_Entrar.TabIndex = 6;
            Button_Entrar.Text = "Entrar";
            Button_Entrar.UseVisualStyleBackColor = false;
            Button_Entrar.Click += Button_Entrar_Click;
            // 
            // Label_Senha
            // 
            Label_Senha.AutoSize = true;
            Label_Senha.Font = new Font("Arial", 12F, FontStyle.Bold);
            Label_Senha.Location = new Point(55, 152);
            Label_Senha.Name = "Label_Senha";
            Label_Senha.Size = new Size(58, 19);
            Label_Senha.TabIndex = 5;
            Label_Senha.Text = "Senha";
            // 
            // TextBox_Senha
            // 
            TextBox_Senha.Cursor = Cursors.IBeam;
            TextBox_Senha.Font = new Font("Arial", 9F);
            TextBox_Senha.ForeColor = Color.Black;
            TextBox_Senha.Location = new Point(57, 174);
            TextBox_Senha.Name = "TextBox_Senha";
            TextBox_Senha.PasswordChar = '•';
            TextBox_Senha.PlaceholderText = "Digite sua senha...";
            TextBox_Senha.Size = new Size(272, 21);
            TextBox_Senha.TabIndex = 4;
            // 
            // TextBox_Email
            // 
            TextBox_Email.Cursor = Cursors.IBeam;
            TextBox_Email.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox_Email.ForeColor = Color.Black;
            TextBox_Email.Location = new Point(57, 114);
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.PlaceholderText = "Digite seu e-mail...";
            TextBox_Email.Size = new Size(272, 21);
            TextBox_Email.TabIndex = 3;
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Email.Location = new Point(55, 92);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(56, 19);
            Label_Email.TabIndex = 2;
            Label_Email.Text = "E-mail";
            // 
            // Label_Semi_Titulo
            // 
            Label_Semi_Titulo.AutoSize = true;
            Label_Semi_Titulo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Semi_Titulo.ForeColor = SystemColors.AppWorkspace;
            Label_Semi_Titulo.Location = new Point(37, 54);
            Label_Semi_Titulo.Name = "Label_Semi_Titulo";
            Label_Semi_Titulo.Size = new Size(321, 15);
            Label_Semi_Titulo.TabIndex = 1;
            Label_Semi_Titulo.Text = "Entre com as suas credenciais para acessar o sistema";
            // 
            // Label_Sistema_Suporte
            // 
            Label_Sistema_Suporte.AutoSize = true;
            Label_Sistema_Suporte.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Sistema_Suporte.Location = new Point(57, 18);
            Label_Sistema_Suporte.Name = "Label_Sistema_Suporte";
            Label_Sistema_Suporte.Size = new Size(272, 32);
            Label_Sistema_Suporte.TabIndex = 0;
            Label_Sistema_Suporte.Text = "Sistema de Suporte";
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormLog";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TextBox_Email;
        private Label Label_Email;
        private Label Label_Semi_Titulo;
        private Label Label_Sistema_Suporte;
        private Button Button_Cancela;
        private Button Button_Entrar;
        private Label Label_Senha;
        private TextBox TextBox_Senha;
    }
}
