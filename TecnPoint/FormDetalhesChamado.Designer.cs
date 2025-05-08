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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVoltar = new Button();
            label5 = new Label();
            cbxNomeFunc = new ComboBox();
            PanelMsg = new FlowLayoutPanel();
            tbxMensagem = new TextBox();
            btnEnviar = new Button();
            cbxStatus = new ComboBox();
            cbxPrioridade = new ComboBox();
            timerLeituraDeMensagens = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13F);
            label2.Location = new Point(388, 273);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11F);
            label3.Location = new Point(354, 34);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 13F);
            label4.Location = new Point(388, 109);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Consolas", 8F);
            btnVoltar.Location = new Point(12, 420);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(55, 28);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11F);
            label5.Location = new Point(455, 34);
            label5.Name = "label5";
            label5.Size = new Size(56, 18);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // cbxNomeFunc
            // 
            cbxNomeFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomeFunc.FormattingEnabled = true;
            cbxNomeFunc.Location = new Point(388, 134);
            cbxNomeFunc.Name = "cbxNomeFunc";
            cbxNomeFunc.Size = new Size(155, 23);
            cbxNomeFunc.TabIndex = 6;
            cbxNomeFunc.SelectedIndexChanged += cbxNomeFunc_SelectedIndexChanged;
            // 
            // PanelMsg
            // 
            PanelMsg.AutoScroll = true;
            PanelMsg.BackColor = Color.Gainsboro;
            PanelMsg.FlowDirection = FlowDirection.TopDown;
            PanelMsg.Location = new Point(26, 109);
            PanelMsg.Name = "PanelMsg";
            PanelMsg.Size = new Size(356, 276);
            PanelMsg.TabIndex = 8;
            PanelMsg.WrapContents = false;
            // 
            // tbxMensagem
            // 
            tbxMensagem.Font = new Font("Consolas", 9F);
            tbxMensagem.Location = new Point(96, 402);
            tbxMensagem.Multiline = true;
            tbxMensagem.Name = "tbxMensagem";
            tbxMensagem.ScrollBars = ScrollBars.Vertical;
            tbxMensagem.Size = new Size(222, 46);
            tbxMensagem.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Image = (Image)resources.GetObject("btnEnviar.Image");
            btnEnviar.Location = new Point(333, 420);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(49, 26);
            btnEnviar.TabIndex = 9;
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Selecione...", "Aberto", "Em andamento", "Pendente", "Resolvido" });
            cbxStatus.Location = new Point(354, 55);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(84, 23);
            cbxStatus.TabIndex = 10;
            cbxStatus.SelectedIndexChanged += cbxStatus_SelectedIndexChanged;
            // 
            // cbxPrioridade
            // 
            cbxPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrioridade.FormattingEnabled = true;
            cbxPrioridade.Items.AddRange(new object[] { "Selecione...", "Baixa", "Média", "Alta" });
            cbxPrioridade.Location = new Point(455, 55);
            cbxPrioridade.Name = "cbxPrioridade";
            cbxPrioridade.Size = new Size(84, 23);
            cbxPrioridade.TabIndex = 11;
            cbxPrioridade.SelectedIndexChanged += cbxPrioridade_SelectedIndexChanged;
            // 
            // timerLeituraDeMensagens
            // 
            timerLeituraDeMensagens.Enabled = true;
            timerLeituraDeMensagens.Interval = 2000;
            timerLeituraDeMensagens.Tick += timerLeituraDeMensagens_Tick;
            // 
            // FormDetalhesChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 460);
            Controls.Add(cbxPrioridade);
            Controls.Add(cbxStatus);
            Controls.Add(btnEnviar);
            Controls.Add(tbxMensagem);
            Controls.Add(PanelMsg);
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
        private FlowLayoutPanel PanelMsg;
        private TextBox tbxMensagem;
        private Button btnEnviar;
        private ComboBox cbxStatus;
        private ComboBox cbxPrioridade;
        private System.Windows.Forms.Timer timerLeituraDeMensagens;
    }
}