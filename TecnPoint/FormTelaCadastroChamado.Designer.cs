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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaCadastroChamado));
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
            lblExplicaJornada = new Label();
            pictureInfoJornada = new PictureBox();
            pictureInfoModulo = new PictureBox();
            lblExplicaModulo = new Label();
            txtbTitulo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureInfoJornada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureInfoModulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtbDescricao
            // 
            txtbDescricao.Cursor = Cursors.IBeam;
            txtbDescricao.Font = new Font("Segoe UI", 12F);
            txtbDescricao.Location = new Point(126, 293);
            txtbDescricao.Multiline = true;
            txtbDescricao.Name = "txtbDescricao";
            txtbDescricao.PlaceholderText = "Descreva o que ocorreu e como ocorreu";
            txtbDescricao.ScrollBars = ScrollBars.Vertical;
            txtbDescricao.Size = new Size(330, 97);
            txtbDescricao.TabIndex = 5;
            txtbDescricao.Leave += txtbDescricao_Leave;
            // 
            // btnAbrirChamado
            // 
            btnAbrirChamado.BackColor = Color.FromArgb(126, 105, 171);
            btnAbrirChamado.Cursor = Cursors.Hand;
            btnAbrirChamado.FlatAppearance.BorderColor = Color.DarkGray;
            btnAbrirChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnAbrirChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnAbrirChamado.FlatStyle = FlatStyle.Flat;
            btnAbrirChamado.Font = new Font("Consolas", 11F);
            btnAbrirChamado.ForeColor = SystemColors.ControlLightLight;
            btnAbrirChamado.Location = new Point(346, 417);
            btnAbrirChamado.Name = "btnAbrirChamado";
            btnAbrirChamado.Size = new Size(110, 30);
            btnAbrirChamado.TabIndex = 6;
            btnAbrirChamado.Text = "Enviar";
            btnAbrirChamado.UseVisualStyleBackColor = false;
            btnAbrirChamado.Click += btnAbrirChamado_Click;
            // 
            // cbxModulo
            // 
            cbxModulo.Cursor = Cursors.Hand;
            cbxModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModulo.Font = new Font("Segoe UI", 12F);
            cbxModulo.FormattingEnabled = true;
            cbxModulo.Items.AddRange(new object[] { "Selecione o módulo...", "Hardware", "Software", "Rede" });
            cbxModulo.Location = new Point(126, 41);
            cbxModulo.Name = "cbxModulo";
            cbxModulo.Size = new Size(330, 29);
            cbxModulo.TabIndex = 1;
            cbxModulo.Leave += cbxModulo_Leave;
            // 
            // cbxJornada
            // 
            cbxJornada.Cursor = Cursors.Hand;
            cbxJornada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxJornada.Font = new Font("Segoe UI", 12F);
            cbxJornada.FormattingEnabled = true;
            cbxJornada.Items.AddRange(new object[] { "Selecione a jornada...", "Financeiro", "Marketing", "Recursos Humanos" });
            cbxJornada.Location = new Point(126, 105);
            cbxJornada.Name = "cbxJornada";
            cbxJornada.Size = new Size(330, 29);
            cbxJornada.TabIndex = 2;
            cbxJornada.Leave += cbxJornada_Leave;
            // 
            // cbxPrioridade
            // 
            cbxPrioridade.Cursor = Cursors.Hand;
            cbxPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrioridade.Font = new Font("Segoe UI", 12F);
            cbxPrioridade.FormattingEnabled = true;
            cbxPrioridade.Items.AddRange(new object[] { "Baixa", "Média", "Alta" });
            cbxPrioridade.Location = new Point(126, 168);
            cbxPrioridade.Name = "cbxPrioridade";
            cbxPrioridade.Size = new Size(330, 29);
            cbxPrioridade.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DarkGray;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 11F);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(230, 417);
            button1.Name = "button1";
            button1.Size = new Size(110, 30);
            button1.TabIndex = 7;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Consolas", 13F);
            lblModulo.Location = new Point(98, 14);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(70, 22);
            lblModulo.TabIndex = 13;
            lblModulo.Text = "Módulo";
            // 
            // lblJornada
            // 
            lblJornada.AutoSize = true;
            lblJornada.Font = new Font("Consolas", 13F);
            lblJornada.Location = new Point(98, 77);
            lblJornada.Name = "lblJornada";
            lblJornada.Size = new Size(80, 22);
            lblJornada.TabIndex = 14;
            lblJornada.Text = "Jornada";
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Font = new Font("Consolas", 13F);
            lblPrioridade.Location = new Point(98, 142);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(110, 22);
            lblPrioridade.TabIndex = 15;
            lblPrioridade.Text = "Prioridade";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 13F);
            lblTitulo.Location = new Point(98, 203);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(70, 22);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Título";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Consolas", 13F);
            lblDescricao.Location = new Point(98, 266);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(100, 22);
            lblDescricao.TabIndex = 17;
            lblDescricao.Text = "Descrição";
            // 
            // lblExplicaJornada
            // 
            lblExplicaJornada.AutoSize = true;
            lblExplicaJornada.Font = new Font("Consolas", 8F);
            lblExplicaJornada.ForeColor = SystemColors.ControlText;
            lblExplicaJornada.Location = new Point(198, 83);
            lblExplicaJornada.Name = "lblExplicaJornada";
            lblExplicaJornada.Size = new Size(235, 13);
            lblExplicaJornada.TabIndex = 18;
            lblExplicaJornada.Text = "Setor em que está ocorrendo o problema";
            lblExplicaJornada.Visible = false;
            // 
            // pictureInfoJornada
            // 
            pictureInfoJornada.Cursor = Cursors.Hand;
            pictureInfoJornada.Image = (Image)resources.GetObject("pictureInfoJornada.Image");
            pictureInfoJornada.Location = new Point(176, 80);
            pictureInfoJornada.Name = "pictureInfoJornada";
            pictureInfoJornada.Size = new Size(20, 19);
            pictureInfoJornada.TabIndex = 19;
            pictureInfoJornada.TabStop = false;
            pictureInfoJornada.Click += pictureInfoJornada_Click;
            // 
            // pictureInfoModulo
            // 
            pictureInfoModulo.Cursor = Cursors.Hand;
            pictureInfoModulo.Image = (Image)resources.GetObject("pictureInfoModulo.Image");
            pictureInfoModulo.Location = new Point(168, 16);
            pictureInfoModulo.Name = "pictureInfoModulo";
            pictureInfoModulo.Size = new Size(19, 20);
            pictureInfoModulo.TabIndex = 20;
            pictureInfoModulo.TabStop = false;
            pictureInfoModulo.Click += pictureInfoModulo_Click;
            // 
            // lblExplicaModulo
            // 
            lblExplicaModulo.AutoSize = true;
            lblExplicaModulo.Font = new Font("Consolas", 8F);
            lblExplicaModulo.Location = new Point(190, 2);
            lblExplicaModulo.Name = "lblExplicaModulo";
            lblExplicaModulo.Size = new Size(199, 39);
            lblExplicaModulo.TabIndex = 21;
            lblExplicaModulo.Text = "Hardware = Componente físico; \r\nSoftware = Programa/Aplicativo; \r\nRede = Internet.";
            lblExplicaModulo.Visible = false;
            // 
            // txtbTitulo
            // 
            txtbTitulo.Cursor = Cursors.IBeam;
            txtbTitulo.Font = new Font("Segoe UI", 12F);
            txtbTitulo.Location = new Point(126, 230);
            txtbTitulo.Name = "txtbTitulo";
            txtbTitulo.PlaceholderText = "Descreva o problema de forma resumida";
            txtbTitulo.Size = new Size(330, 29);
            txtbTitulo.TabIndex = 4;
            txtbTitulo.Leave += txtbTitulo_Leave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormTelaCadastroChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 460);
            Controls.Add(lblExplicaModulo);
            Controls.Add(pictureInfoModulo);
            Controls.Add(pictureInfoJornada);
            Controls.Add(lblExplicaJornada);
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
            ((System.ComponentModel.ISupportInitialize)pictureInfoJornada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureInfoModulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label lblExplicaJornada;
        private PictureBox pictureInfoJornada;
        private PictureBox pictureInfoModulo;
        private Label lblExplicaModulo;
        private TextBox txtbTitulo;
        private ErrorProvider errorProvider1;
    }
}