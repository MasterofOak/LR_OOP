using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_17
{
     public class Vector3D : Norm
    {
        float x;
        float y;
        float z;
        public Vector3D(float X,float Y,float Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public float Z
        {
            get { return z; }
            set { z = value; }
        }
        public override double getModule() => Math.Sqrt(x * x + y * y + z * z);
        public override double getNorm()
        {
            if(x > y && x > z)
            {
                return x;
            }
            else if(y > x && y > z)
            {
                return y;
            }
            return z;
        }
    }
}
