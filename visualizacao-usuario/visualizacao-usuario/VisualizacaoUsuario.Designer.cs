namespace visualizacao_usuario
{
    partial class VisualizacaoUsuario
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
            buttonAcompanharChamado = new Button();
            buttonCriarChamado = new Button();
            label1 = new Label();
            label2 = new Label();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(218, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 458);
            panel1.TabIndex = 0;
            // 
            // buttonAcompanharChamado
            // 
            buttonAcompanharChamado.BackColor = Color.Transparent;
            buttonAcompanharChamado.Cursor = Cursors.Hand;
            buttonAcompanharChamado.FlatAppearance.BorderSize = 0;
            buttonAcompanharChamado.FlatStyle = FlatStyle.Flat;
            buttonAcompanharChamado.Location = new Point(12, 121);
            buttonAcompanharChamado.Name = "buttonAcompanharChamado";
            buttonAcompanharChamado.Size = new Size(189, 33);
            buttonAcompanharChamado.TabIndex = 1;
            buttonAcompanharChamado.Text = "Acompanhar chamado";
            buttonAcompanharChamado.UseVisualStyleBackColor = false;
            buttonAcompanharChamado.Click += buttonAcompanharChamado_Click;
            // 
            // buttonCriarChamado
            // 
            buttonCriarChamado.Cursor = Cursors.Hand;
            buttonCriarChamado.FlatAppearance.BorderSize = 0;
            buttonCriarChamado.FlatStyle = FlatStyle.Flat;
            buttonCriarChamado.Location = new Point(12, 163);
            buttonCriarChamado.Name = "buttonCriarChamado";
            buttonCriarChamado.Size = new Size(189, 33);
            buttonCriarChamado.TabIndex = 2;
            buttonCriarChamado.Text = "Criar chamado";
            buttonCriarChamado.UseVisualStyleBackColor = true;
            buttonCriarChamado.Click += buttonCriarChamado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 56);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(23, 23);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Magenta;
            iconPictureBox1.Enabled = false;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 80;
            iconPictureBox1.Location = new Point(16, 16);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(80, 80);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // VisualizacaoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Magenta;
            ClientSize = new Size(800, 450);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCriarChamado);
            Controls.Add(buttonAcompanharChamado);
            Controls.Add(panel1);
            Name = "VisualizacaoUsuario";
            Text = "Tecn Point";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonAcompanharChamado;
        private Button buttonCriarChamado;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
