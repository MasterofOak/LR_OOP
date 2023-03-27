using System;

namespace LR_17
{
    class Complex : Norm
    {
        double a;
        double b;
        public Complex(double A, double B)
        {
            a = A;
            b = B;
        }
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public override double getModule() => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        public override double getNorm() => getModule() * getModule();

    }
}
