namespace LR_15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.result_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result_btn = new System.Windows.Forms.Button();
            this.x_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.area_value = new System.Windows.Forms.TextBox();
            this.length_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.circle_btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.n_value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.check_btn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.b_value = new System.Windows.Forms.TextBox();
            this.a_value = new System.Windows.Forms.TextBox();
            this.calac_btn = new System.Windows.Forms.Button();
            this.result_value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.find_btn = new System.Windows.Forms.Button();
            this.const_n = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.valid_numbers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.TextBox();
            this.k_btn = new System.Windows.Forms.Button();
            this.k_words = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valid_numbers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.result_field);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.result_btn);
            this.tabPage1.Controls.Add(this.x_value);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "№1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // result_field
            // 
            this.result_field.Location = new System.Drawing.Point(95, 78);
            this.result_field.Name = "result_field";
            this.result_field.Size = new System.Drawing.Size(118, 26);
            this.result_field.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // result_btn
            // 
            this.result_btn.Location = new System.Drawing.Point(32, 129);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(181, 42);
            this.result_btn.TabIndex = 3;
            this.result_btn.Text = "Eval";
            this.result_btn.UseVisualStyleBackColor = true;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // x_value
            // 
            this.x_value.Location = new System.Drawing.Point(95, 41);
            this.x_value.Name = "x_value";
            this.x_value.Size = new System.Drawing.Size(118, 26);
            this.x_value.TabIndex = 2;
            this.x_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_value_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input x:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.area_value);
            this.tabPage2.Controls.Add(this.length_value);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.circle_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "№2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // area_value
            // 
            this.area_value.Location = new System.Drawing.Point(141, 80);
            this.area_value.Name = "area_value";
            this.area_value.Size = new System.Drawing.Size(142, 26);
            this.area_value.TabIndex = 4;
            // 
            // length_value
            // 
            this.length_value.Location = new System.Drawing.Point(141, 26);
            this.length_value.Name = "length_value";
            this.length_value.Size = new System.Drawing.Size(142, 26);
            this.length_value.TabIndex = 3;
            this.length_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.length_value_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Area (in cm^2):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Length (in cm):";
            // 
            // circle_btn
            // 
            this.circle_btn.Location = new System.Drawing.Point(14, 130);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(269, 50);
            this.circle_btn.TabIndex = 0;
            this.circle_btn.Text = "Find area";
            this.circle_btn.UseVisualStyleBackColor = true;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.n_value);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.check_btn);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "№3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // n_value
            // 
            this.n_value.Location = new System.Drawing.Point(162, 26);
            this.n_value.Name = "n_value";
            this.n_value.Size = new System.Drawing.Size(100, 26);
            this.n_value.TabIndex = 3;
            this.n_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_value_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "є повним квадратом";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Натуральне число:";
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(14, 77);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(214, 45);
            this.check_btn.TabIndex = 0;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.b_value);
            this.tabPage4.Controls.Add(this.a_value);
            this.tabPage4.Controls.Add(this.calac_btn);
            this.tabPage4.Controls.Add(this.result_value);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.b);
            this.tabPage4.Controls.Add(this.a);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(796, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "№4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // b_value
            // 
            this.b_value.Location = new System.Drawing.Point(87, 69);
            this.b_value.Name = "b_value";
            this.b_value.Size = new System.Drawing.Size(136, 26);
            this.b_value.TabIndex = 6;
            // 
            // a_value
            // 
            this.a_value.Location = new System.Drawing.Point(87, 37);
            this.a_value.Name = "a_value";
            this.a_value.Size = new System.Drawing.Size(136, 26);
            this.a_value.TabIndex = 5;
            // 
            // calac_btn
            // 
            this.calac_btn.Location = new System.Drawing.Point(26, 149);
            this.calac_btn.Name = "calac_btn";
            this.calac_btn.Size = new System.Drawing.Size(197, 53);
            this.calac_btn.TabIndex = 4;
            this.calac_btn.Text = "Calculate";
            this.calac_btn.UseVisualStyleBackColor = true;
            this.calac_btn.Click += new System.EventHandler(this.calac_btn_Click);
            // 
            // result_value
            // 
            this.result_value.Location = new System.Drawing.Point(87, 101);
            this.result_value.Name = "result_value";
            this.result_value.Size = new System.Drawing.Size(136, 26);
            this.result_value.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Result:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(22, 69);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(22, 20);
            this.b.TabIndex = 1;
            this.b.Text = "b:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(22, 37);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(22, 20);
            this.a.TabIndex = 0;
            this.a.Text = "a:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.valid_numbers);
            this.tabPage5.Controls.Add(this.find_btn);
            this.tabPage5.Controls.Add(this.const_n);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(796, 420);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "№5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(365, 38);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(214, 41);
            this.find_btn.TabIndex = 2;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // const_n
            // 
            this.const_n.Location = new System.Drawing.Point(132, 45);
            this.const_n.Name = "const_n";
            this.const_n.Size = new System.Drawing.Size(155, 26);
            this.const_n.TabIndex = 1;
            this.const_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.const_n_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Обмеження N:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(796, 420);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "№6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.k_words);
            this.tabPage7.Controls.Add(this.k_btn);
            this.tabPage7.Controls.Add(this.user_text);
            this.tabPage7.Controls.Add(this.label9);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(796, 420);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "№7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // valid_numbers
            // 
            this.valid_numbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valid_numbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.valid_numbers.Location = new System.Drawing.Point(14, 104);
            this.valid_numbers.Name = "valid_numbers";
            this.valid_numbers.RowHeadersWidth = 62;
            this.valid_numbers.RowTemplate.Height = 28;
            this.valid_numbers.Size = new System.Drawing.Size(565, 313);
            this.valid_numbers.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Index";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Right Numbers";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Input text:";
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(136, 28);
            this.user_text.Multiline = true;
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(615, 155);
            this.user_text.TabIndex = 1;
            // 
            // k_btn
            // 
            this.k_btn.Location = new System.Drawing.Point(23, 88);
            this.k_btn.Name = "k_btn";
            this.k_btn.Size = new System.Drawing.Size(74, 95);
            this.k_btn.TabIndex = 2;
            this.k_btn.Text = "Find k";
            this.k_btn.UseVisualStyleBackColor = true;
            this.k_btn.Click += new System.EventHandler(this.k_btn_Click);
            // 
            // k_words
            // 
            this.k_words.AutoSize = true;
            this.k_words.Location = new System.Drawing.Point(23, 249);
            this.k_words.Name = "k_words";
            this.k_words.Size = new System.Drawing.Size(0, 20);
            this.k_words.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Не знаю рішення";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valid_numbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox x_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button result_btn;
        private System.Windows.Forms.TextBox area_value;
        private System.Windows.Forms.TextBox length_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.TextBox n_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox b_value;
        private System.Windows.Forms.TextBox a_value;
        private System.Windows.Forms.Button calac_btn;
        private System.Windows.Forms.TextBox result_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.TextBox const_n;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView valid_numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button k_btn;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label k_words;
        private System.Windows.Forms.Label label10;
    }
}

