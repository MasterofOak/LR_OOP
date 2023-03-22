using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(x_value.Text);
            double result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - 7 * x / (Math.Pow(x, 3) - (double)15 * x);
            result_field.Text = Convert.ToString(result);
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(length_value.Text);
            double area = Math.Pow(((length * Math.PI) / (2 * Math.PI)), 2) * Math.PI;
            area_value.Text = Convert.ToString(area);
        }

        private void x_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (x_value.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    result_btn.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void length_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (length_value.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    circle_btn.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            long n = Convert.ToInt64(n_value.Text);
            bool check = true;
            if(!(Math.Sqrt(n)%1 == 0))
            {
                check = false;
                check_btn.Text = Convert.ToString(check);
            }
            check_btn.Text = Convert.ToString(check);
        }

        private void n_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (n_value.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    check_btn.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calac_btn_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(a_value.Text);
            double b = Convert.ToDouble(b_value.Text);
            result_value.Text = Convert.ToString("0");
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            int lim = Convert.ToInt32(const_n.Text);
            int[] numbers = {};
            for (int n = 1;n <= lim; n++)
            {
                if (allDigitsDivide(n))
                {
                    numbers = numbers.Append(n).ToArray();
                }
            }
            for(int i = 1 ;i < numbers.Length; i++)
            {
                valid_numbers.Rows.Add(i, numbers[i]);
            }
        }
        static bool checkDivisibility(int n, int digit)
        {
            return (digit != 0 && n % digit == 0);
        }

        static bool allDigitsDivide(int n)
        {
            int temp = n;
            while (temp > 0)
            {

                int digit = temp % 10;

                if ((checkDivisibility(n, digit)) == false)
                    return false;

                temp /= 10;
            }
            return true;
        }

        private void const_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (const_n.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    find_btn.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void k_btn_Click(object sender, EventArgs e)
        {
            string text = user_text.Text;
            string[] words = text.Split(' '); 
            foreach( var word in words)
            {
                if (word.Contains("k"))
                {
                    k_words.Text += word + ",";
                }
            }
        }
    }
}
