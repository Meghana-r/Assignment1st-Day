using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Shapes
    {
        double Shapearea;
        public void area(int side)
        {
            Shapearea = side * side;
            Console.WriteLine("The area of square:" + Shapearea);
        }
        public void area(int length,int  breadth)
        {
            Shapearea = length * breadth;
            Console.WriteLine("The area of RECTANGLE:" + Shapearea);
        }
        public void circle(int radius)
        {
            Shapearea = 3.14 * radius;
            Console.WriteLine("The area of CIRCLE:" + Shapearea);
        }
        public void area(int a,double b)
        {
            Shapearea = 1/2 *0.5 * a*b;
            Console.WriteLine("The area of TRIANGLE:" + Shapearea);
        }
    }
}
