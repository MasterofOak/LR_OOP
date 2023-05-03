namespace LR25
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.arrival = new System.Windows.Forms.Label();
            this.departure = new System.Windows.Forms.Label();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox2_from = new System.Windows.Forms.TextBox();
            this.textBox3_to = new System.Windows.Forms.TextBox();
            this.textBox4_arrival = new System.Windows.Forms.TextBox();
            this.textBox5_departure = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(820, 347);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add to DB";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(12, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 30);
            this.id.TabIndex = 3;
            this.id.Text = "ID";
            this.id.UseCompatibleTextRendering = true;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(12, 57);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(54, 25);
            this.from.TabIndex = 4;
            this.from.Text = "From";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(12, 95);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(30, 25);
            this.to.TabIndex = 5;
            this.to.Text = "To";
            // 
            // arrival
            // 
            this.arrival.AutoSize = true;
            this.arrival.Location = new System.Drawing.Point(12, 132);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(62, 25);
            this.arrival.TabIndex = 6;
            this.arrival.Text = "Arrival";
            // 
            // departure
            // 
            this.departure.AutoSize = true;
            this.departure.Location = new System.Drawing.Point(12, 169);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(91, 25);
            this.departure.TabIndex = 7;
            this.departure.Text = "Departure";
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(116, 21);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(150, 31);
            this.textBox1_id.TabIndex = 8;
            // 
            // textBox2_from
            // 
            this.textBox2_from.Location = new System.Drawing.Point(116, 54);
            this.textBox2_from.Name = "textBox2_from";
            this.textBox2_from.Size = new System.Drawing.Size(150, 31);
            this.textBox2_from.TabIndex = 9;
            // 
            // textBox3_to
            // 
            this.textBox3_to.Location = new System.Drawing.Point(116, 91);
            this.textBox3_to.Name = "textBox3_to";
            this.textBox3_to.Size = new System.Drawing.Size(150, 31);
            this.textBox3_to.TabIndex = 10;
            // 
            // textBox4_arrival
            // 
            this.textBox4_arrival.Location = new System.Drawing.Point(116, 126);
            this.textBox4_arrival.Name = "textBox4_arrival";
            this.textBox4_arrival.Size = new System.Drawing.Size(150, 31);
            this.textBox4_arrival.TabIndex = 11;
            // 
            // textBox5_departure
            // 
            this.textBox5_departure.Location = new System.Drawing.Point(116, 163);
            this.textBox5_departure.Name = "textBox5_departure";
            this.textBox5_departure.Size = new System.Drawing.Size(150, 31);
            this.textBox5_departure.TabIndex = 12;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(438, 29);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(169, 31);
            this.searchBox.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 565);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.textBox5_departure);
            this.Controls.Add(this.textBox4_arrival);
            this.Controls.Add(this.textBox3_to);
            this.Controls.Add(this.textBox2_from);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label id;
        private Label from;
        private Label to;
        private Label arrival;
        private Label departure;
        private TextBox textBox1_id;
        private TextBox textBox2_from;
        private TextBox textBox3_to;
        private TextBox textBox4_arrival;
        private TextBox textBox5_departure;
        private TextBox searchBox;
        private Button button3;
    }
}