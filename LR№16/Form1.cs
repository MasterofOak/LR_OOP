using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void act_btn_Click(object sender, EventArgs e)
        {
            Fraction newFractions = new Fraction(new double[4] { 4.5, 1.5, 2.5, 1.75 });
            Fraction newFractions1 = new Fraction(new double[] { 4.5, 1.5, 2.5, 1.75, 8.6, 14.3, 9.6 }, 6);
            Fraction newFractions2 = newFractions1;
            double sumAll()
            {
                double sum = 0;
                foreach (double element in newFractions.Fractions)
                {
                    sum += element;
                }
                return sum;
            }
            double average()
            {
                double aver = sumAll() / newFractions.length;
                return aver;
            }
            showSum.Text = decimalToFraction(sumAll()).ToString();
            showAver.Text = decimalToFraction(average()).ToString();
            add_f.Text = decimalToFraction(newFractions.add(0,3, newFractions.Fractions)).ToString();
            sub_f.Text = decimalToFraction(newFractions.substract(0,3, newFractions.Fractions)).ToString();
            mult_f.Text = decimalToFraction(newFractions.multiply(2,3, newFractions.Fractions)).ToString();
            div_f.Text = decimalToFraction(newFractions.divide(0,2, newFractions.Fractions)).ToString();
            pow_f.Text = decimalToFraction(newFractions.power(3, newFractions.Fractions)).ToString();
            com_f.Text = newFractions.compare(2, 3, ">", newFractions.Fractions);
            double gcd(long a, long b)
            {
                if (a == 0)
                    return b;
                else if (b == 0)
                    return a;
                if (a < b)
                    return gcd(a, b % a);
                else
                    return gcd(b, a % b);
            }

            // Function to convert decimal to fraction
            string decimalToFraction(double number)
            {

                // Fetch integral value of the decimal
                double intVal = Math.Floor(number);

                // Fetch fractional part of the decimal
                double fVal = number - intVal;

                // Consider precision value to
                // convert fractional part to
                // integral equivalent
                long pVal = 1000000000;

                // Calculate GCD of integral
                // equivalent of fractional
                // part and precision value
                double gcdVal = gcd((long)Math.Round(
                                fVal * pVal), pVal);

                // Calculate num and deno
                double num = (long)Math.Round(fVal * pVal) / gcdVal;
                double deno = pVal / gcdVal;

                // return the fraction
                return ((long)(intVal * deno) + num + "/" + deno);
            }
        }
    }
}
