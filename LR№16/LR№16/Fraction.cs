using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LR_16
{
    public class Fraction
    {
        double[] fractions = {};
        public int length;
        public Fraction()
        {
            this.fractions = new double[5];
            this.length = 0;
        }
        ~Fraction()
        {
            
        }
        public Fraction(double[] fractions)
        {
            this.fractions = fractions;
            this.length = fractions.Length;
        }
        public Fraction(double[] fractions, int length)
        {
            this.fractions = fractions;
            this.length = length;
        }

        public double[] Fractions
        {
            get { return fractions; }
            set { fractions = value; }
        }
        public void reduceFraction()
        {
            
        }
        public double add(int index1,int index2, double[] fractions)
        {
            return fractions[index1] + fractions[index2];
        }
        public double substract(int index1, int index2, double[] fractions)
        {
            return fractions[index1] - fractions[index2];
        }
        public double multiply(int index1, int index2, double[] fractions)
        {
            return fractions[index1] * fractions[index2];
        }
        public double divide(int index1, int index2, double[] fractions)
        {
            return fractions[index1] / fractions[index2];
        }
        public double power(int index,double[] fractions)
        {
            return fractions[index] * fractions[index];
        }
        public string compare(int index1, int index2, string sign, double[] fractions)
        {
            string compare = "";
            if (sign == ">")
            {
                compare = Convert.ToString(fractions[index1] > fractions[index2]);
            }
            else if (sign == "<")
            {
                compare = Convert.ToString(fractions[index1] < fractions[index2]);
            }
           else if (sign == ">=")
          {
                compare = Convert.ToString(fractions[index1] >= fractions[index2]);
            }
           else if (sign == "<=")
           {
                compare = Convert.ToString(fractions[index1] <= fractions[index2]);
           }
            else if (sign == "=")
           {
                compare = Convert.ToString(fractions[index1] == fractions[index2]);
            }
            return compare;
        }

    }
}
