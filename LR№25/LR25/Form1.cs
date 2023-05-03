using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LR25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "csv File|*.csv|Text File|*.txt|All Files|*.";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                string[][] data = new string[lines.Length][];
                int i = 0;
                foreach (string line in lines)
                {
                    data[i] = line.Split(";");
                    i++;
                }

                dataGridView1.DataSource = array2dt<string>(data);

            }
        }
        public static DataTable array2dt<T>(T[][] arr)
        {
            DataTable dt = new DataTable();
            for(int i= 0; i < arr[0].Length; i++)
            {
               dt.Columns.Add();
            }
            for (int j = 1; j < arr.Length; j++)
            {
                DataRow row = dt.NewRow();
                for (int i = 0; i < arr[j].Length; i++)
                {
                    row[i] = arr[j][i];
                }
                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "From";
                dt.Columns[2].ColumnName = "To";
                dt.Columns[3].ColumnName = "Arrival";
                dt.Columns[4].ColumnName = "Departure";
                dt.Rows.Add(row);
            }
            return dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string first = textBox1_id.Text;
            string second = textBox2_from.Text;
            string third = textBox3_to.Text;
            string fourth = textBox4_arrival.Text;
            string fifth = textBox5_departure.Text;
            using (var writer = new StreamWriter("D:\\Games\\c++\\LR25\\LR25\\TrainSchedule.csv", true))
            {
                if(first != "" && second != "" && third != "" && fourth != "" && fifth != "")
                {
                    writer.WriteLine(first+";"+ second + ";"+ third + ";"+ fourth + ";" + fifth);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("id like '%" + searchBox.Text + "%'");
        }
    }
}