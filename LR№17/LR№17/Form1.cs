using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            var compNum= new Complex(5.2, 2.4);
            var vecNum = new Vector3D(2, 8, 4);
            print(compNum, vecNum);
            void print(Norm norm, Norm norm1)
            {
                c_value.Text = $"Complex Norm:{norm.getNorm()} Complex Module:{norm.getModule()}";
                v_value.Text = $"Vector Module:{norm1.getModule()}" + $"Vector Norm:{norm1.getNorm()}";
            }
        }
    }
}
