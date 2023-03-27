namespace LR_17
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
            this.label2 = new System.Windows.Forms.Label();
            this.c_value = new System.Windows.Forms.TextBox();
            this.v_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // act_btn
            // 
            this.act_btn.Location = new System.Drawing.Point(26, 204);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(336, 101);
            this.act_btn.TabIndex = 0;
            this.act_btn.Text = "Action";
            this.act_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.act_btn.UseVisualStyleBackColor = true;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Complex class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vector3D class:";
            // 
            // c_value
            // 
            this.c_value.Location = new System.Drawing.Point(184, 12);
            this.c_value.Multiline = true;
            this.c_value.Name = "c_value";
            this.c_value.Size = new System.Drawing.Size(334, 88);
            this.c_value.TabIndex = 4;
            // 
            // v_value
            // 
            this.v_value.Location = new System.Drawing.Point(184, 114);
            this.v_value.Multiline = true;
            this.v_value.Name = "v_value";
            this.v_value.Size = new System.Drawing.Size(334, 84);
            this.v_value.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.v_value);
            this.Controls.Add(this.c_value);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_value;
        private System.Windows.Forms.TextBox v_value;
    }
}

