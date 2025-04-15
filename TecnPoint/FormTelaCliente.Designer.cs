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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // NomeUsuario
            // 
            NomeUsuario.AutoSize = true;
            NomeUsuario.BackColor = Color.Transparent;
            NomeUsuario.ForeColor = Color.Gainsboro;
            NomeUsuario.Location = new Point(75, 22);
            NomeUsuario.Name = "NomeUsuario";
            NomeUsuario.Size = new Size(83, 15);
            NomeUsuario.TabIndex = 0;
            NomeUsuario.Text = "Nome Usuario";
            // 
            // EmailUsuario
            // 
            EmailUsuario.AutoSize = true;
            EmailUsuario.BackColor = Color.Transparent;
            EmailUsuario.ForeColor = Color.Gainsboro;
            EmailUsuario.Location = new Point(75, 47);
            EmailUsuario.Name = "EmailUsuario";
            EmailUsuario.Size = new Size(79, 15);
            EmailUsuario.TabIndex = 1;
            EmailUsuario.Text = "Email Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DarkGray;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Properties.Resources.PlusIconActive;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 111);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 2;
            button1.Text = "Criar um chamado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.DarkGray;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Image = Properties.Resources.ChecklistIconActive;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(10, 158);
            button2.Name = "button2";
            button2.Size = new Size(190, 40);
            button2.TabIndex = 3;
            button2.Text = "Acompanhar um chamado";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(221, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 345);
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
            // FormTelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(EmailUsuario);
            Controls.Add(NomeUsuario);
            DoubleBuffered = true;
            Name = "FormTelaCliente";
            Text = "FormTelaCliente";
            Closed += FormTelaCliente_Closed;
            Load += FormTelaCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeUsuario;
        private Label EmailUsuario;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private GroupBox groupBox1;
    }
}