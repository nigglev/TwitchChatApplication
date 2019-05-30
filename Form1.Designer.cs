namespace TwitchChatTest1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbTwitchLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAuthTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnectChat = new System.Windows.Forms.Button();
            this.btnGetAuthTicket = new System.Windows.Forms.Button();
            this.tbChannelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChatLog = new System.Windows.Forms.TextBox();
            this.timerTwitchChat = new System.Windows.Forms.Timer(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTwitchLogin
            // 
            this.tbTwitchLogin.Location = new System.Drawing.Point(12, 25);
            this.tbTwitchLogin.Name = "tbTwitchLogin";
            this.tbTwitchLogin.Size = new System.Drawing.Size(184, 20);
            this.tbTwitchLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Twitch Login";
            // 
            // tbAuthTicket
            // 
            this.tbAuthTicket.Location = new System.Drawing.Point(348, 23);
            this.tbAuthTicket.Name = "tbAuthTicket";
            this.tbAuthTicket.Size = new System.Drawing.Size(184, 20);
            this.tbAuthTicket.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Auth Ticket";
            // 
            // btnConnectChat
            // 
            this.btnConnectChat.Location = new System.Drawing.Point(205, 70);
            this.btnConnectChat.Name = "btnConnectChat";
            this.btnConnectChat.Size = new System.Drawing.Size(128, 23);
            this.btnConnectChat.TabIndex = 2;
            this.btnConnectChat.Text = "Connect Chat";
            this.btnConnectChat.UseVisualStyleBackColor = true;
            this.btnConnectChat.Click += new System.EventHandler(this.BtnConnectChat_Click);
            // 
            // btnGetAuthTicket
            // 
            this.btnGetAuthTicket.Location = new System.Drawing.Point(202, 23);
            this.btnGetAuthTicket.Name = "btnGetAuthTicket";
            this.btnGetAuthTicket.Size = new System.Drawing.Size(139, 23);
            this.btnGetAuthTicket.TabIndex = 2;
            this.btnGetAuthTicket.Text = "Get Auth Ticket";
            this.btnGetAuthTicket.UseVisualStyleBackColor = true;
            this.btnGetAuthTicket.Click += new System.EventHandler(this.BtnGetAuthTicket_Click);
            // 
            // tbChannelName
            // 
            this.tbChannelName.Location = new System.Drawing.Point(15, 73);
            this.tbChannelName.Name = "tbChannelName";
            this.tbChannelName.Size = new System.Drawing.Size(184, 20);
            this.tbChannelName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Channel Name";
            // 
            // tbChatLog
            // 
            this.tbChatLog.Location = new System.Drawing.Point(15, 99);
            this.tbChatLog.Multiline = true;
            this.tbChatLog.Name = "tbChatLog";
            this.tbChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChatLog.Size = new System.Drawing.Size(651, 220);
            this.tbChatLog.TabIndex = 3;
            // 
            // timerTwitchChat
            // 
            this.timerTwitchChat.Enabled = true;
            this.timerTwitchChat.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(348, 70);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect Chat";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChannelName);
            this.Controls.Add(this.tbChatLog);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnectChat);
            this.Controls.Add(this.btnGetAuthTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAuthTicket);
            this.Controls.Add(this.tbTwitchLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Twitch Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTwitchLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAuthTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnectChat;
        private System.Windows.Forms.Button btnGetAuthTicket;
        private System.Windows.Forms.TextBox tbChannelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChatLog;
        private System.Windows.Forms.Timer timerTwitchChat;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

