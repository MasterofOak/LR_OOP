using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            string str = "Madam i'm Adam";
            try
            {

                isPalindrom(str);
            }
            catch(Exception ex)
            {
                result.Text = ex.Message;
            }
        }
        public void isPalindrom(string str)
        {
            string copy = "";
            string[] specialChar = {"-",":","'",".","," };
            foreach(string item in specialChar)
            {
                int index = str.IndexOf(item);
                if (index >= 0)
                {
                    copy = str.Remove(index, 1);
                }
            }
            char[] stringArray = copy.Replace(" ", "").ToLower().ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            if (copy.Replace(" ", "").ToLower() == reversedStr)
            {
                result.Text = "String is palindrom";
            }
            else
            {
                throw new Exception("String is not palinfrom");
            }
        }
    }
}
