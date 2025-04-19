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
            botaoCriarChamado = new Button();
            botaoAcompanharChamado = new Button();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // botaoCriarChamado
            // 
            botaoCriarChamado.BackColor = Color.Transparent;
            botaoCriarChamado.Cursor = Cursors.Hand;
            botaoCriarChamado.FlatAppearance.BorderColor = Color.DarkGray;
            botaoCriarChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            botaoCriarChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            botaoCriarChamado.FlatStyle = FlatStyle.Flat;
            botaoCriarChamado.ForeColor = Color.Gainsboro;
            botaoCriarChamado.Image = Properties.Resources.PlusIconActive;
            botaoCriarChamado.ImageAlign = ContentAlignment.MiddleLeft;
            botaoCriarChamado.Location = new Point(10, 111);
            botaoCriarChamado.Name = "botaoCriarChamado";
            botaoCriarChamado.Size = new Size(190, 40);
            botaoCriarChamado.TabIndex = 2;
            botaoCriarChamado.Text = "Criar um chamado";
            botaoCriarChamado.UseVisualStyleBackColor = false;
            botaoCriarChamado.Click += botaoCriarChamado_Click;
            // 
            // botaoAcompanharChamado
            // 
            botaoAcompanharChamado.BackColor = Color.Transparent;
            botaoAcompanharChamado.Cursor = Cursors.Hand;
            botaoAcompanharChamado.FlatAppearance.BorderColor = Color.DarkGray;
            botaoAcompanharChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            botaoAcompanharChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            botaoAcompanharChamado.FlatStyle = FlatStyle.Flat;
            botaoAcompanharChamado.ForeColor = Color.Gainsboro;
            botaoAcompanharChamado.Image = Properties.Resources.ChecklistIconActive;
            botaoAcompanharChamado.ImageAlign = ContentAlignment.MiddleLeft;
            botaoAcompanharChamado.Location = new Point(10, 158);
            botaoAcompanharChamado.Name = "botaoAcompanharChamado";
            botaoAcompanharChamado.Size = new Size(190, 40);
            botaoAcompanharChamado.TabIndex = 3;
            botaoAcompanharChamado.Text = "Acompanhar um chamado";
            botaoAcompanharChamado.TextAlign = ContentAlignment.MiddleRight;
            botaoAcompanharChamado.UseVisualStyleBackColor = false;
            botaoAcompanharChamado.Click += botaoAcompanharChamado_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(221, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 345);
            panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(25, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 73);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 43);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 19);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
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
            Controls.Add(botaoAcompanharChamado);
            Controls.Add(botaoCriarChamado);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(EmailUsuario);
            Controls.Add(NomeUsuario);
            DoubleBuffered = true;
            Name = "FormTelaCliente";
            Text = "FormTelaCliente";
            Closed += FormTelaCliente_Closed;
            Load += FormTelaCliente_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeUsuario;
        private Label EmailUsuario;
        private Button botaoCriarChamado;
        private Button botaoAcompanharChamado;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}