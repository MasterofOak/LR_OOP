namespace LR24
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
            this.all_thr = new System.Windows.Forms.Button();
            this.all_thr_stop = new System.Windows.Forms.Button();
            this.launch1 = new System.Windows.Forms.Button();
            this.stop1 = new System.Windows.Forms.Button();
            this.stop2 = new System.Windows.Forms.Button();
            this.launch2 = new System.Windows.Forms.Button();
            this.stop3 = new System.Windows.Forms.Button();
            this.launch3 = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            this.SuspendLayout();
            // 
            // all_thr
            // 
            this.all_thr.Location = new System.Drawing.Point(12, 346);
            this.all_thr.Name = "all_thr";
            this.all_thr.Size = new System.Drawing.Size(776, 42);
            this.all_thr.TabIndex = 0;
            this.all_thr.Text = "Launch All Threads";
            this.all_thr.UseVisualStyleBackColor = true;
            this.all_thr.Click += new System.EventHandler(this.all_thr_Click);
            // 
            // all_thr_stop
            // 
            this.all_thr_stop.Location = new System.Drawing.Point(12, 394);
            this.all_thr_stop.Name = "all_thr_stop";
            this.all_thr_stop.Size = new System.Drawing.Size(776, 44);
            this.all_thr_stop.TabIndex = 1;
            this.all_thr_stop.Text = "Stop All Threads";
            this.all_thr_stop.UseVisualStyleBackColor = true;
            this.all_thr_stop.Click += new System.EventHandler(this.all_thr_stop_Click);
            // 
            // launch1
            // 
            this.launch1.Location = new System.Drawing.Point(78, 223);
            this.launch1.Name = "launch1";
            this.launch1.Size = new System.Drawing.Size(126, 44);
            this.launch1.TabIndex = 2;
            this.launch1.Text = "Launch 1";
            this.launch1.UseVisualStyleBackColor = true;
            this.launch1.Click += new System.EventHandler(this.launch1_Click);
            // 
            // stop1
            // 
            this.stop1.Location = new System.Drawing.Point(78, 274);
            this.stop1.Name = "stop1";
            this.stop1.Size = new System.Drawing.Size(126, 46);
            this.stop1.TabIndex = 3;
            this.stop1.Text = "Stop 1 Thread";
            this.stop1.UseVisualStyleBackColor = true;
            this.stop1.Click += new System.EventHandler(this.stop1_Click);
            // 
            // stop2
            // 
            this.stop2.Location = new System.Drawing.Point(370, 274);
            this.stop2.Name = "stop2";
            this.stop2.Size = new System.Drawing.Size(126, 46);
            this.stop2.TabIndex = 5;
            this.stop2.Text = "Stop 2 Thread";
            this.stop2.UseVisualStyleBackColor = true;
            this.stop2.Click += new System.EventHandler(this.stop2_Click);
            // 
            // launch2
            // 
            this.launch2.Location = new System.Drawing.Point(370, 223);
            this.launch2.Name = "launch2";
            this.launch2.Size = new System.Drawing.Size(126, 44);
            this.launch2.TabIndex = 4;
            this.launch2.Text = "Launch 2";
            this.launch2.UseVisualStyleBackColor = true;
            this.launch2.Click += new System.EventHandler(this.launch2_Click);
            // 
            // stop3
            // 
            this.stop3.Location = new System.Drawing.Point(631, 274);
            this.stop3.Name = "stop3";
            this.stop3.Size = new System.Drawing.Size(126, 46);
            this.stop3.TabIndex = 7;
            this.stop3.Text = "Stop 3 Thread";
            this.stop3.UseVisualStyleBackColor = true;
            this.stop3.Click += new System.EventHandler(this.stop3_Click);
            // 
            // launch3
            // 
            this.launch3.Location = new System.Drawing.Point(631, 223);
            this.launch3.Name = "launch3";
            this.launch3.Size = new System.Drawing.Size(126, 44);
            this.launch3.TabIndex = 6;
            this.launch3.Text = "Launch 3";
            this.launch3.UseVisualStyleBackColor = true;
            this.launch3.Click += new System.EventHandler(this.launch3_Click);
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(34, 21);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(222, 196);
            this.Box1.TabIndex = 8;
            this.Box1.TabStop = false;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(328, 21);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(202, 196);
            this.Box2.TabIndex = 9;
            this.Box2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(594, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 196);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.stop3);
            this.Controls.Add(this.launch3);
            this.Controls.Add(this.stop2);
            this.Controls.Add(this.launch2);
            this.Controls.Add(this.stop1);
            this.Controls.Add(this.launch1);
            this.Controls.Add(this.all_thr_stop);
            this.Controls.Add(this.all_thr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button all_thr;
        private System.Windows.Forms.Button all_thr_stop;
        private System.Windows.Forms.Button launch1;
        private System.Windows.Forms.Button stop1;
        private System.Windows.Forms.Button stop2;
        private System.Windows.Forms.Button launch2;
        private System.Windows.Forms.Button stop3;
        private System.Windows.Forms.Button launch3;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

