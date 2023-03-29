namespace LR_18
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
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.max_value = new System.Windows.Forms.TextBox();
            this.arr_value = new System.Windows.Forms.TextBox();
            this.sub_value = new System.Windows.Forms.TextBox();
            this.aver_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(21, 216);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(120, 88);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Максимальний елемент";
            // 
            // max_value
            // 
            this.max_value.Location = new System.Drawing.Point(240, 23);
            this.max_value.Name = "max_value";
            this.max_value.Size = new System.Drawing.Size(248, 26);
            this.max_value.TabIndex = 2;
            // 
            // arr_value
            // 
            this.arr_value.Location = new System.Drawing.Point(240, 72);
            this.arr_value.Name = "arr_value";
            this.arr_value.Size = new System.Drawing.Size(248, 26);
            this.arr_value.TabIndex = 3;
            // 
            // sub_value
            // 
            this.sub_value.Location = new System.Drawing.Point(240, 120);
            this.sub_value.Name = "sub_value";
            this.sub_value.Size = new System.Drawing.Size(248, 26);
            this.sub_value.TabIndex = 4;
            // 
            // aver_value
            // 
            this.aver_value.Location = new System.Drawing.Point(240, 166);
            this.aver_value.Name = "aver_value";
            this.aver_value.Size = new System.Drawing.Size(248, 26);
            this.aver_value.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Про індекси";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Різниця двох елементів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Середнє геометричне";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aver_value);
            this.Controls.Add(this.sub_value);
            this.Controls.Add(this.arr_value);
            this.Controls.Add(this.max_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox max_value;
        private System.Windows.Forms.TextBox arr_value;
        private System.Windows.Forms.TextBox sub_value;
        private System.Windows.Forms.TextBox aver_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

