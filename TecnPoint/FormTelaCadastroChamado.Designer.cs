namespace TecnPoint.Interface
{
    partial class FormTelaCadastroChamado
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
            txtbTitulo = new TextBox();
            txtbDescricao = new TextBox();
            btnAbrirChamado = new Button();
            cbxModulo = new ComboBox();
            cbxJornada = new ComboBox();
            cbxPrioridade = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtbTitulo
            // 
            txtbTitulo.Location = new Point(77, 145);
            txtbTitulo.Name = "txtbTitulo";
            txtbTitulo.PlaceholderText = "Título";
            txtbTitulo.Size = new Size(330, 23);
            txtbTitulo.TabIndex = 0;
            // 
            // txtbDescricao
            // 
            txtbDescricao.Location = new Point(77, 190);
            txtbDescricao.Multiline = true;
            txtbDescricao.Name = "txtbDescricao";
            txtbDescricao.PlaceholderText = "Descricao";
            txtbDescricao.Size = new Size(330, 118);
            txtbDescricao.TabIndex = 1;
            // 
            // btnAbrirChamado
            // 
            btnAbrirChamado.BackColor = Color.FromArgb(126, 105, 171);
            btnAbrirChamado.Cursor = Cursors.Hand;
            btnAbrirChamado.FlatStyle = FlatStyle.Flat;
            btnAbrirChamado.ForeColor = SystemColors.ControlLightLight;
            btnAbrirChamado.Location = new Point(317, 315);
            btnAbrirChamado.Name = "btnAbrirChamado";
            btnAbrirChamado.Size = new Size(90, 23);
            btnAbrirChamado.TabIndex = 8;
            btnAbrirChamado.Text = "Enviar";
            btnAbrirChamado.UseVisualStyleBackColor = false;
            btnAbrirChamado.Click += btnAbrirChamado_Click;
            // 
            // cbxModulo
            // 
            cbxModulo.Cursor = Cursors.Hand;
            cbxModulo.FormattingEnabled = true;
            cbxModulo.Items.AddRange(new object[] { "Selecione o módulo...", "Hardware", "Software", "Rede" });
            cbxModulo.Location = new Point(77, 30);
            cbxModulo.Name = "cbxModulo";
            cbxModulo.Size = new Size(330, 23);
            cbxModulo.TabIndex = 9;
            cbxModulo.Text = "Módulo";
            // 
            // cbxJornada
            // 
            cbxJornada.Cursor = Cursors.Hand;
            cbxJornada.FormattingEnabled = true;
            cbxJornada.Items.AddRange(new object[] { "Selecione a jornada...", "Financeiro", "Marketing", "Recursos Humanos", "Jurídico" });
            cbxJornada.Location = new Point(77, 70);
            cbxJornada.Name = "cbxJornada";
            cbxJornada.Size = new Size(330, 23);
            cbxJornada.TabIndex = 10;
            cbxJornada.Text = "Jornada";
            // 
            // cbxPrioridade
            // 
            cbxPrioridade.Cursor = Cursors.Hand;
            cbxPrioridade.FormattingEnabled = true;
            cbxPrioridade.Items.AddRange(new object[] { "Baixa", "Média", "Alta" });
            cbxPrioridade.Location = new Point(77, 105);
            cbxPrioridade.Name = "cbxPrioridade";
            cbxPrioridade.Size = new Size(330, 23);
            cbxPrioridade.TabIndex = 11;
            cbxPrioridade.Text = "Prioridade";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(221, 315);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 52);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 14;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 91);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 126);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 16;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 172);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 17;
            label5.Text = "label5";
            // 
            // FormTelaCadastroChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 345);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cbxPrioridade);
            Controls.Add(cbxJornada);
            Controls.Add(cbxModulo);
            Controls.Add(btnAbrirChamado);
            Controls.Add(txtbDescricao);
            Controls.Add(txtbTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTelaCadastroChamado";
            Text = "FormTelaCadastroChamado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbTitulo;
        private TextBox txtbDescricao;
        private Button btnAbrirChamado;
        private ComboBox cbxModulo;
        private ComboBox cbxJornada;
        private ComboBox cbxPrioridade;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}