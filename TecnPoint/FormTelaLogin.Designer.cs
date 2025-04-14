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
            button1 = new Button();
            email = new TextBox();
            senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(126, 105, 171);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(257, 240);
            button1.Name = "button1";
            button1.Size = new Size(185, 23);
            button1.TabIndex = 0;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Location = new Point(230, 141);
            email.Name = "email";
            email.Size = new Size(240, 23);
            email.TabIndex = 1;
            // 
            // senha
            // 
            senha.Anchor = AnchorStyles.None;
            senha.Cursor = Cursors.IBeam;
            senha.Location = new Point(230, 191);
            senha.Name = "senha";
            senha.PasswordChar = '*';
            senha.Size = new Size(240, 23);
            senha.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 120);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 3;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 170);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Berlin Sans FB Demi", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 50);
            label3.Name = "label3";
            label3.Size = new Size(179, 31);
            label3.TabIndex = 5;
            label3.Text = "Tech Solutions";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(280, 83);
            label4.Name = "label4";
            label4.Size = new Size(139, 13);
            label4.TabIndex = 6;
            label4.Text = "Entre com suas credenciais";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(270, 275);
            label5.Name = "label5";
            label5.Size = new Size(157, 13);
            label5.TabIndex = 7;
            label5.Text = "Sistema de Suporte ao Cliente";
            // 
            // FormTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(senha);
            Controls.Add(email);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTelaLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox email;
        private TextBox senha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
