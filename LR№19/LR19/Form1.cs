using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LR19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            string str1 = "if (num1 > num2) return num1;"; 
            string str2 = "(if (num1 > num2) return num1;";
            string findMatch(string str)
            {
                int i = 0;
                int counter1 = 0; int counter2 = 0;
                while ((i = str.IndexOf("(", i) + 1) != 0)
                {
                    i++;
                    counter1++;
                }
                i = 0;
                while ((i = str.IndexOf(")", i) + 1) != 0)
                {
                    i++;
                    counter2++;
                }
                if (counter1 == counter2)
                {
                    return "Parentheses are placed correctly";
                }
                else
                {
                    return "Parentheses are not placed correctly";
                }
            }
            result1.Text = findMatch(str1);
            result2.Text = findMatch(str2);
        }
    }
}