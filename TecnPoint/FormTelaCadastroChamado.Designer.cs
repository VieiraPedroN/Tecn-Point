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
            lblModulo = new Label();
            lblJornada = new Label();
            lblPrioridade = new Label();
            lblTitulo = new Label();
            lblDescricao = new Label();
            SuspendLayout();
            // 
            // txtbTitulo
            // 
            txtbTitulo.Location = new Point(77, 167);
            txtbTitulo.Name = "txtbTitulo";
            txtbTitulo.PlaceholderText = "Descreva o problema de forma resumida";
            txtbTitulo.Size = new Size(330, 23);
            txtbTitulo.TabIndex = 0;
            // 
            // txtbDescricao
            // 
            txtbDescricao.Location = new Point(77, 211);
            txtbDescricao.Multiline = true;
            txtbDescricao.Name = "txtbDescricao";
            txtbDescricao.PlaceholderText = "Descreva o que ocorreu e como ocorreu";
            txtbDescricao.Size = new Size(330, 97);
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
            cbxModulo.Location = new Point(77, 35);
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
            cbxJornada.Location = new Point(77, 79);
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
            cbxPrioridade.Location = new Point(77, 123);
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
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(66, 17);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 13;
            lblModulo.Text = "Módulo";
            // 
            // lblJornada
            // 
            lblJornada.AutoSize = true;
            lblJornada.Location = new Point(66, 61);
            lblJornada.Name = "lblJornada";
            lblJornada.Size = new Size(44, 15);
            lblJornada.TabIndex = 14;
            lblJornada.Text = "Jonada";
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new Point(66, 105);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(61, 15);
            lblPrioridade.TabIndex = 15;
            lblPrioridade.Text = "Prioridade";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(66, 149);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Titulo";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(66, 193);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 17;
            lblDescricao.Text = "Descrição";
            // 
            // FormTelaCadastroChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 345);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Controls.Add(lblPrioridade);
            Controls.Add(lblJornada);
            Controls.Add(lblModulo);
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
        private Label lblModulo;
        private Label lblJornada;
        private Label lblPrioridade;
        private Label lblTitulo;
        private Label lblDescricao;
    }
}