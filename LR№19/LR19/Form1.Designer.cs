namespace LR19
{
    partial class Form1
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
            this.act_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // act_btn
            // 
            this.act_btn.Location = new System.Drawing.Point(17, 135);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(242, 71);
            this.act_btn.TabIndex = 0;
            this.act_btn.Text = "Start";
            this.act_btn.UseVisualStyleBackColor = true;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "result1:";
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(113, 48);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(361, 26);
            this.result1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "result2";
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(113, 90);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(361, 26);
            this.result2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.act_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result2;
    }
}

