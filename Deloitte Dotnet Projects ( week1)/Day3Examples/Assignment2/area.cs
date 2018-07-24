using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace area
{
    class area
    {
        int a, b;
        float r;
        float x, y;
        float pi = 3.14f;
        float ar;


        [MethodInfo(MethodName ="getArea",ReturnType ="int",Parameter =1,Message ="this is the area of a square")]
        public float getArea( int a )
        {
            ar = a * a;
            return ar;
        }
        public float getArea(int a , int b)
        {
            ar = a * b;
            return ar;
        }

        public float getArea (float x , float y)
        {
            ar = (x * y)/2;
            return ar;
        }

        public float getArea ( float r)
        {
            ar = pi * r * r;
            return ar;
        }
    }
}
