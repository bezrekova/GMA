using System;
using System.Collections.Generic;

namespace Rectangle.Rectangle
{
    class Rectangle : IComparable<Rectangle>
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public Rectangle(double a, double b)
        {
            SideA = a;
            SideB = b;
        }

        public double GetPerim()
        {
            return this.SideA * 2 + this.SideB * 2;
        }
       

        public int CompareTo(Rectangle other)
        {
            return this.GetPerim().CompareTo(other.GetPerim());
        }

        public override string ToString()
        {
            return $"This rectangle with A={this.SideA} and B={this.SideB} has perim={this.GetPerim()}";
        }

        private static void Main(string[] args)
        {
            List<Rectangle> recList = new List<Rectangle>
            {
                new Rectangle(2, 4.5),
                new Rectangle(2.5, 7.5),
                new Rectangle(3.6, 9.7),
                new Rectangle(4.7, 1.5)
            };

            recList.Sort();
            foreach (var rect in recList)
            {
                Console.WriteLine(rect);
            }

            Console.ReadKey();
        }
    }
}
