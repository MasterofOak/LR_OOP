using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            int[] arr = { 4, 3, 9, 1, 5, 2, 8, 15, 22, 30 };
            int[,] Rank_arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            void findMax()
            {
                double max = arr[0];
                int index = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        index = i;
                    }
                }
                max_value.Text = index.ToString();
            }
            void halfArr()
            {
                for (int i = 2; i < arr.Length; i++)
                {
                     int j;
                    if (!(i % 2 == 0))
                    {
                        int tmp = arr[i];
                        for (j = i; j > i / 2; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[j] = tmp;
                    }
                }
                for (int q = 0; q < arr.Length; q++)
                {
                    arr_value.Text += arr[q] + "  ";
                }

            }
            void substraction(int row1 ,int column1, int row2 , int column2)
            {
                sub_value.Text = (Rank_arr[row1 - 1, column1 - 1] - Rank_arr[row2 - 1, column2 - 1]).ToString();
            }
            void geoAverage(int row1, int column1, int row2, int column2)
            {
                aver_value.Text = Math.Sqrt(Rank_arr[row1 - 1, column1 - 1] * Rank_arr[row2 - 1, column2 - 1]).ToString();
            }
            findMax();
            halfArr();
            substraction(2,3,1,2);
            geoAverage(1, 2, 2, 1);
        }
    }
}
