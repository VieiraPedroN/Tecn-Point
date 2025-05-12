namespace TecnPoint.Interface
{
    partial class FormTelaChatbot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaChatbot));
            flpChatbot = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbxMensagem = new TextBox();
            btnEnviarMensagem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flpChatbot
            // 
            flpChatbot.AutoScroll = true;
            flpChatbot.BackColor = Color.White;
            flpChatbot.FlowDirection = FlowDirection.TopDown;
            flpChatbot.Location = new Point(-1, 52);
            flpChatbot.Name = "flpChatbot";
            flpChatbot.Size = new Size(556, 355);
            flpChatbot.TabIndex = 0;
            flpChatbot.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 52, 144);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 52);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 17F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 27);
            label1.TabIndex = 0;
            label1.Text = "TECN BOT";
            // 
            // tbxMensagem
            // 
            tbxMensagem.Font = new Font("Segoe UI", 11F);
            tbxMensagem.Location = new Point(119, 413);
            tbxMensagem.Multiline = true;
            tbxMensagem.Name = "tbxMensagem";
            tbxMensagem.PlaceholderText = "Digite aqui...";
            tbxMensagem.Size = new Size(286, 40);
            tbxMensagem.TabIndex = 2;
            // 
            // btnEnviarMensagem
            // 
            btnEnviarMensagem.Image = (Image)resources.GetObject("btnEnviarMensagem.Image");
            btnEnviarMensagem.Location = new Point(411, 419);
            btnEnviarMensagem.Name = "btnEnviarMensagem";
            btnEnviarMensagem.Size = new Size(48, 31);
            btnEnviarMensagem.TabIndex = 3;
            btnEnviarMensagem.UseVisualStyleBackColor = true;
            btnEnviarMensagem.Click += btnEnviarMensagem_Click;
            // 
            // FormTelaChatbot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 460);
            Controls.Add(btnEnviarMensagem);
            Controls.Add(tbxMensagem);
            Controls.Add(panel1);
            Controls.Add(flpChatbot);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTelaChatbot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tecn Point";
            Load += FormTelaChatbot_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpChatbot;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox tbxMensagem;
        private Button btnEnviarMensagem;
    }
}