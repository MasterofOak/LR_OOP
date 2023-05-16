namespace LR29
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.saveChatBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(635, 12);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 43);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Enter";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(635, 70);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 43);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(635, 375);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(153, 63);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a name:";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(146, 27);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(447, 31);
            this.userNameBox.TabIndex = 4;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 358);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(581, 83);
            this.messageBox.TabIndex = 5;
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(12, 119);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(776, 233);
            this.chatBox.TabIndex = 6;
            // 
            // saveChatBtn
            // 
            this.saveChatBtn.Location = new System.Drawing.Point(12, 74);
            this.saveChatBtn.Name = "saveChatBtn";
            this.saveChatBtn.Size = new System.Drawing.Size(112, 39);
            this.saveChatBtn.TabIndex = 7;
            this.saveChatBtn.Text = "Save Chat";
            this.saveChatBtn.UseVisualStyleBackColor = true;
            this.saveChatBtn.Click += new System.EventHandler(this.saveChatBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveChatBtn);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginBtn;
        private Button exitBtn;
        private Button sendBtn;
        private Label label1;
        private TextBox userNameBox;
        private TextBox messageBox;
        private TextBox chatBox;
        private Button saveChatBtn;
    }
}