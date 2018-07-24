using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    class Rectangle : Shapes
    {
        int len;
        int brd;

        public override void DisplayShapes()
        {
            base.DisplayShapes(); // this eill call the parent class method
            Console.WriteLine(" Rectangle class");
        }

        public override void DisplayArea()
        {
            //throw new NotImplementedException();
            len = 200;
            brd = 50;
            area = len * brd;
            Console.WriteLine(" area of rectangle  :  " + area);

        }


    }
}
