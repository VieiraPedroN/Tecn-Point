namespace TecnPoint.Interface
{
    partial class FormTelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaFuncionario));
            NomeUsuario = new Label();
            EmailUsuario = new Label();
            botaoAcompanharChamado = new Button();
            panel1 = new Panel();
            lblSubtituloTelaInicioFunc = new Label();
            lblTituloTelaInicioFunc = new Label();
            groupBox1 = new GroupBox();
            btnAddUser = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NomeUsuario
            // 
            NomeUsuario.AutoSize = true;
            NomeUsuario.BackColor = Color.Transparent;
            NomeUsuario.Font = new Font("Consolas", 11F);
            NomeUsuario.ForeColor = Color.Gainsboro;
            NomeUsuario.Location = new Point(80, 23);
            NomeUsuario.Name = "NomeUsuario";
            NomeUsuario.Size = new Size(104, 18);
            NomeUsuario.TabIndex = 0;
            NomeUsuario.Text = "Nome Usuario";
            // 
            // EmailUsuario
            // 
            EmailUsuario.AutoSize = true;
            EmailUsuario.BackColor = Color.Transparent;
            EmailUsuario.Font = new Font("Consolas", 11F);
            EmailUsuario.ForeColor = Color.Gainsboro;
            EmailUsuario.Location = new Point(80, 48);
            EmailUsuario.Name = "EmailUsuario";
            EmailUsuario.Size = new Size(112, 18);
            EmailUsuario.TabIndex = 1;
            EmailUsuario.Text = "Email Usuario";
            // 
            // botaoAcompanharChamado
            // 
            botaoAcompanharChamado.BackColor = Color.Transparent;
            botaoAcompanharChamado.Cursor = Cursors.Hand;
            botaoAcompanharChamado.FlatAppearance.BorderColor = Color.DarkGray;
            botaoAcompanharChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            botaoAcompanharChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            botaoAcompanharChamado.FlatStyle = FlatStyle.Flat;
            botaoAcompanharChamado.Font = new Font("Consolas", 11F);
            botaoAcompanharChamado.ForeColor = Color.Gainsboro;
            botaoAcompanharChamado.Image = Properties.Resources.ChecklistIconActive;
            botaoAcompanharChamado.ImageAlign = ContentAlignment.MiddleLeft;
            botaoAcompanharChamado.Location = new Point(10, 111);
            botaoAcompanharChamado.Name = "botaoAcompanharChamado";
            botaoAcompanharChamado.Size = new Size(232, 40);
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
            panel1.Controls.Add(lblSubtituloTelaInicioFunc);
            panel1.Controls.Add(lblTituloTelaInicioFunc);
            panel1.Location = new Point(248, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 460);
            panel1.TabIndex = 4;
            // 
            // lblSubtituloTelaInicioFunc
            // 
            lblSubtituloTelaInicioFunc.AutoSize = true;
            lblSubtituloTelaInicioFunc.BackColor = Color.Transparent;
            lblSubtituloTelaInicioFunc.Font = new Font("Consolas", 8F);
            lblSubtituloTelaInicioFunc.Location = new Point(146, 332);
            lblSubtituloTelaInicioFunc.Name = "lblSubtituloTelaInicioFunc";
            lblSubtituloTelaInicioFunc.Size = new Size(295, 13);
            lblSubtituloTelaInicioFunc.TabIndex = 1;
            lblSubtituloTelaInicioFunc.Text = "Unidos pelo desafio, moldados pelo conhecimento.";
            // 
            // lblTituloTelaInicioFunc
            // 
            lblTituloTelaInicioFunc.AutoSize = true;
            lblTituloTelaInicioFunc.BackColor = Color.Transparent;
            lblTituloTelaInicioFunc.Font = new Font("Consolas", 32F, FontStyle.Bold);
            lblTituloTelaInicioFunc.Location = new Point(116, 281);
            lblTituloTelaInicioFunc.Name = "lblTituloTelaInicioFunc";
            lblTituloTelaInicioFunc.Size = new Size(358, 51);
            lblTituloTelaInicioFunc.TabIndex = 0;
            lblTituloTelaInicioFunc.Text = "Tech Solutions";
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
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Transparent;
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatAppearance.BorderColor = Color.DarkGray;
            btnAddUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
            btnAddUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Image = Properties.Resources.Add_User;
            btnAddUser.Location = new Point(12, 408);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(30, 30);
            btnAddUser.TabIndex = 6;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // FormTelaFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 52, 144);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddUser);
            Controls.Add(botaoAcompanharChamado);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(EmailUsuario);
            Controls.Add(NomeUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTelaFuncionario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormTelaFuncionario";
            Closed += FormTelaCliente_Closed;
            Load += FormTelaCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeUsuario;
        private Label EmailUsuario;
        private Button botaoAcompanharChamado;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnAddUser;
        private Label lblTituloTelaInicioFunc;
        private Label lblSubtituloTelaInicioFunc;
    }
}