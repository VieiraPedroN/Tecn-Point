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
            buttonAcompanharChamado.Location = new Point(23, 127);
            buttonAcompanharChamado.Name = "buttonAcompanharChamado";
            buttonAcompanharChamado.Size = new Size(168, 94);
            buttonAcompanharChamado.TabIndex = 1;
            buttonAcompanharChamado.Text = "Acompanhar chamado";
            buttonAcompanharChamado.UseVisualStyleBackColor = true;
            buttonAcompanharChamado.Click += buttonAcompanharChamado_Click;
            // 
            // buttonCriarChamado
            // 
            buttonCriarChamado.Location = new Point(23, 242);
            buttonCriarChamado.Name = "buttonCriarChamado";
            buttonCriarChamado.Size = new Size(168, 94);
            buttonCriarChamado.TabIndex = 2;
            buttonCriarChamado.Text = "Criar chamado";
            buttonCriarChamado.UseVisualStyleBackColor = true;
            buttonCriarChamado.Click += buttonCriarChamado_Click;
            // 
            // VisualizacaoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCriarChamado);
            Controls.Add(buttonAcompanharChamado);
            Controls.Add(panel1);
            Name = "VisualizacaoUsuario";
            Text = "Tecn Point";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonAcompanharChamado;
        private Button buttonCriarChamado;
    }
}
