using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


            namespace RectangleApplication
    {
        class Rectangle
        {
            private double length;
            private double width;

            public void Acceptdetails()
            {
                length = 10;
                width = 15;
            }

            public double GetArea()
            {
                return length * width;
            }

            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }

        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.Acceptdetails();
                r.Display();
                Console.ReadLine();
            }
        }
    }

