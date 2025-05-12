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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalhesChamado));
            lblTitulo = new Label();
            lblCliente = new Label();
            lblStatus = new Label();
            lblFuncionario = new Label();
            btnVoltar = new Button();
            lblPrioridade = new Label();
            cbxNomeFunc = new ComboBox();
            PanelMsg = new FlowLayoutPanel();
            tbxMensagem = new TextBox();
            btnEnviar = new Button();
            cbxStatus = new ComboBox();
            cbxPrioridade = new ComboBox();
            timerLeituraDeMensagens = new System.Windows.Forms.Timer(components);
            lblExibeStatus = new Label();
            lblExibePrioridade = new Label();
            lblFuncResponsavel = new Label();
            lblCriadoPeloCliente = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 15F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(109, 23);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "lblTitulo";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Consolas", 11F);
            lblCliente.Location = new Point(391, 250);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(88, 18);
            lblCliente.TabIndex = 13;
            lblCliente.Text = "lblCliente";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Consolas", 10F);
            lblStatus.Location = new Point(327, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 17);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "lblStatus";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Consolas", 11F);
            lblFuncionario.Location = new Point(391, 150);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(120, 18);
            lblFuncionario.TabIndex = 12;
            lblFuncionario.Text = "lblFuncionario";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Consolas", 8F);
            btnVoltar.Location = new Point(12, 420);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(56, 28);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button1_Click;
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Font = new Font("Consolas", 10F);
            lblPrioridade.Location = new Point(447, 34);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(112, 17);
            lblPrioridade.TabIndex = 10;
            lblPrioridade.Text = "lblPrioridade";
            // 
            // cbxNomeFunc
            // 
            cbxNomeFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomeFunc.FormattingEnabled = true;
            cbxNomeFunc.Location = new Point(374, 180);
            cbxNomeFunc.Name = "cbxNomeFunc";
            cbxNomeFunc.Size = new Size(155, 23);
            cbxNomeFunc.TabIndex = 2;
            cbxNomeFunc.SelectedIndexChanged += cbxNomeFunc_SelectedIndexChanged;
            // 
            // PanelMsg
            // 
            PanelMsg.AutoScroll = true;
            PanelMsg.BackColor = Color.Gainsboro;
            PanelMsg.FlowDirection = FlowDirection.TopDown;
            PanelMsg.Location = new Point(12, 109);
            PanelMsg.Name = "PanelMsg";
            PanelMsg.Size = new Size(356, 291);
            PanelMsg.TabIndex = 11;
            PanelMsg.WrapContents = false;
            // 
            // tbxMensagem
            // 
            tbxMensagem.Font = new Font("Consolas", 9F);
            tbxMensagem.Location = new Point(91, 406);
            tbxMensagem.Multiline = true;
            tbxMensagem.Name = "tbxMensagem";
            tbxMensagem.ScrollBars = ScrollBars.Vertical;
            tbxMensagem.Size = new Size(222, 40);
            tbxMensagem.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.Image = (Image)resources.GetObject("btnEnviar.Image");
            btnEnviar.Location = new Point(319, 420);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(49, 26);
            btnEnviar.TabIndex = 5;
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Selecione...", "Aberto", "Em andamento", "Pendente", "Resolvido" });
            cbxStatus.Location = new Point(327, 55);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(89, 23);
            cbxStatus.TabIndex = 0;
            cbxStatus.SelectedIndexChanged += cbxStatus_SelectedIndexChanged;
            // 
            // cbxPrioridade
            // 
            cbxPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrioridade.FormattingEnabled = true;
            cbxPrioridade.Items.AddRange(new object[] { "Selecione...", "Baixa", "Média", "Alta" });
            cbxPrioridade.Location = new Point(447, 55);
            cbxPrioridade.Name = "cbxPrioridade";
            cbxPrioridade.Size = new Size(89, 23);
            cbxPrioridade.TabIndex = 1;
            cbxPrioridade.SelectedIndexChanged += cbxPrioridade_SelectedIndexChanged;
            // 
            // timerLeituraDeMensagens
            // 
            timerLeituraDeMensagens.Enabled = true;
            timerLeituraDeMensagens.Interval = 2000;
            timerLeituraDeMensagens.Tick += timerLeituraDeMensagens_Tick;
            // 
            // lblExibeStatus
            // 
            lblExibeStatus.AutoSize = true;
            lblExibeStatus.Font = new Font("Consolas", 10F);
            lblExibeStatus.Location = new Point(319, 9);
            lblExibeStatus.Name = "lblExibeStatus";
            lblExibeStatus.Size = new Size(64, 17);
            lblExibeStatus.TabIndex = 7;
            lblExibeStatus.Text = "Status:";
            // 
            // lblExibePrioridade
            // 
            lblExibePrioridade.AutoSize = true;
            lblExibePrioridade.Font = new Font("Consolas", 10F);
            lblExibePrioridade.Location = new Point(440, 9);
            lblExibePrioridade.Name = "lblExibePrioridade";
            lblExibePrioridade.Size = new Size(96, 17);
            lblExibePrioridade.TabIndex = 8;
            lblExibePrioridade.Text = "Prioridade:";
            // 
            // lblFuncResponsavel
            // 
            lblFuncResponsavel.AutoSize = true;
            lblFuncResponsavel.Font = new Font("Consolas", 11F);
            lblFuncResponsavel.Location = new Point(375, 120);
            lblFuncResponsavel.Name = "lblFuncResponsavel";
            lblFuncResponsavel.Size = new Size(104, 18);
            lblFuncResponsavel.TabIndex = 14;
            lblFuncResponsavel.Text = "Responsavel:";
            // 
            // lblCriadoPeloCliente
            // 
            lblCriadoPeloCliente.AutoSize = true;
            lblCriadoPeloCliente.Font = new Font("Consolas", 11F);
            lblCriadoPeloCliente.Location = new Point(375, 220);
            lblCriadoPeloCliente.Name = "lblCriadoPeloCliente";
            lblCriadoPeloCliente.Size = new Size(96, 18);
            lblCriadoPeloCliente.TabIndex = 15;
            lblCriadoPeloCliente.Text = "Criado por:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.TECH;
            pictureBox1.Location = new Point(386, 296);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FormDetalhesChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 460);
            Controls.Add(pictureBox1);
            Controls.Add(lblCriadoPeloCliente);
            Controls.Add(lblFuncResponsavel);
            Controls.Add(lblExibePrioridade);
            Controls.Add(lblExibeStatus);
            Controls.Add(cbxPrioridade);
            Controls.Add(cbxStatus);
            Controls.Add(btnEnviar);
            Controls.Add(tbxMensagem);
            Controls.Add(PanelMsg);
            Controls.Add(cbxNomeFunc);
            Controls.Add(lblPrioridade);
            Controls.Add(btnVoltar);
            Controls.Add(lblStatus);
            Controls.Add(lblFuncionario);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetalhesChamado";
            Text = "FormDetalhesChamados";
            Load += FormDetalhesChamado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCliente;
        private Label lblStatus;
        private Label lblFuncionario;
        private Button btnVoltar;
        private Label lblPrioridade;
        private ComboBox cbxNomeFunc;
        private FlowLayoutPanel PanelMsg;
        private TextBox tbxMensagem;
        private Button btnEnviar;
        private ComboBox cbxStatus;
        private ComboBox cbxPrioridade;
        private System.Windows.Forms.Timer timerLeituraDeMensagens;
        private Label lblExibeStatus;
        private Label lblExibePrioridade;
        private Label lblFuncResponsavel;
        private Label lblCriadoPeloCliente;
        private PictureBox pictureBox1;
    }
}