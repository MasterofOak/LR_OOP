namespace LR20
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
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // act_btn
            // 
            this.act_btn.Location = new System.Drawing.Point(20, 114);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(149, 53);
            this.act_btn.TabIndex = 0;
            this.act_btn.Text = "Action";
            this.act_btn.UseVisualStyleBackColor = true;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(20, 38);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(371, 26);
            this.result.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.act_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.TextBox result;
    }
}

