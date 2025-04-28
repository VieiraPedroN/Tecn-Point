namespace TecnPoint.Interface
{
    partial class FormDetalhesChamado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVoltar = new Button();
            label5 = new Label();
            cbxNomeFunc = new ComboBox();
            btnAtribuicao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Bold);
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13F);
            label2.Location = new Point(399, 323);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11F);
            label3.Location = new Point(367, 22);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 13F);
            label4.Location = new Point(399, 109);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Consolas", 11F);
            btnVoltar.Location = new Point(12, 413);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(90, 35);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11F);
            label5.Location = new Point(443, 22);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // cbxNomeFunc
            // 
            cbxNomeFunc.FormattingEnabled = true;
            cbxNomeFunc.Location = new Point(360, 134);
            cbxNomeFunc.Name = "cbxNomeFunc";
            cbxNomeFunc.Size = new Size(155, 23);
            cbxNomeFunc.TabIndex = 6;
            // 
            // btnAtribuicao
            // 
            btnAtribuicao.Location = new Point(399, 163);
            btnAtribuicao.Name = "btnAtribuicao";
            btnAtribuicao.Size = new Size(75, 23);
            btnAtribuicao.TabIndex = 7;
            btnAtribuicao.Text = "Atribuir";
            btnAtribuicao.UseVisualStyleBackColor = true;
            btnAtribuicao.Click += btnAtribuicao_Click;
            // 
            // FormDetalhesChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 460);
            Controls.Add(btnAtribuicao);
            Controls.Add(cbxNomeFunc);
            Controls.Add(label5);
            Controls.Add(btnVoltar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetalhesChamado";
            Text = "FormDetalhesChamados";
            Load += FormDetalhesChamado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVoltar;
        private Label label5;
        private ComboBox cbxNomeFunc;
        private Button btnAtribuicao;
    }
}