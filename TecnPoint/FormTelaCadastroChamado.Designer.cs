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
            SuspendLayout();
            // 
            // txtbTitulo
            // 
            txtbTitulo.Location = new Point(123, 100);
            txtbTitulo.Name = "txtbTitulo";
            txtbTitulo.PlaceholderText = "Título";
            txtbTitulo.Size = new Size(210, 23);
            txtbTitulo.TabIndex = 0;
            // 
            // txtbDescricao
            // 
            txtbDescricao.Location = new Point(124, 129);
            txtbDescricao.Multiline = true;
            txtbDescricao.Name = "txtbDescricao";
            txtbDescricao.PlaceholderText = "Descricao";
            txtbDescricao.Size = new Size(210, 161);
            txtbDescricao.TabIndex = 1;
            // 
            // btnAbrirChamado
            // 
            btnAbrirChamado.Location = new Point(124, 310);
            btnAbrirChamado.Name = "btnAbrirChamado";
            btnAbrirChamado.Size = new Size(210, 23);
            btnAbrirChamado.TabIndex = 8;
            btnAbrirChamado.Text = "Abrir chamado";
            btnAbrirChamado.UseVisualStyleBackColor = true;
            btnAbrirChamado.Click += btnAbrirChamado_Click;
            // 
            // cbxModulo
            // 
            cbxModulo.FormattingEnabled = true;
            cbxModulo.Items.AddRange(new object[] { "Selecione o módulo...", "Hardware", "Software", "Rede" });
            cbxModulo.Location = new Point(124, 13);
            cbxModulo.Name = "cbxModulo";
            cbxModulo.Size = new Size(210, 23);
            cbxModulo.TabIndex = 9;
            cbxModulo.Text = "Módulo";
            // 
            // cbxJornada
            // 
            cbxJornada.FormattingEnabled = true;
            cbxJornada.Items.AddRange(new object[] { "Selecione a jornada...", "Financeiro", "Marketing", "Recursos Humanos", "Jurídico" });
            cbxJornada.Location = new Point(123, 42);
            cbxJornada.Name = "cbxJornada";
            cbxJornada.Size = new Size(211, 23);
            cbxJornada.TabIndex = 10;
            cbxJornada.Text = "Jornada";
            // 
            // cbxPrioridade
            // 
            cbxPrioridade.FormattingEnabled = true;
            cbxPrioridade.Items.AddRange(new object[] { "Baixa", "Média", "Alta" });
            cbxPrioridade.Location = new Point(123, 71);
            cbxPrioridade.Name = "cbxPrioridade";
            cbxPrioridade.Size = new Size(211, 23);
            cbxPrioridade.TabIndex = 11;
            cbxPrioridade.Text = "Prioridade";
            // 
            // FormTelaCadastroChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 345);
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
    }
}