using System;

namespace ProgramTwelve
{
    class Rectangle
    {
        int width;
        int height;

        Rectangle(int width, int height) {
            this.width = width;
            this.height = height;
        }

        public static Rectangle operator +(Rectangle a, Rectangle b)
        {
            int totalWidth = a.width + b.width;
            int totalHeight = a.height + b.height;
            return new Rectangle(totalWidth, totalHeight);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Perform Operator Overloading.");
            Rectangle r1 = new Rectangle(40, 60);
            Rectangle r2 = new Rectangle(60, 40);
            Console.WriteLine("-----------------");
            Console.WriteLine("First Rectangle");
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("Rectangle Width: {0}", r1.width);
            Console.WriteLine("Rectangle Height: {0}", r1.height);
            
            Console.WriteLine();

            Console.WriteLine("-----------------");
            Console.WriteLine("Second Rectangle");
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("Rectangle Width: {0}", r2.width);
            Console.WriteLine("Rectangle Height: {0}", r2.height);

            Console.WriteLine();            

            Rectangle r3 = r1 + r2;
            Console.WriteLine("Total Width: {0}", r3.width);
            Console.WriteLine("Total Height: {0}", r3.height);
            Console.ReadKey();
        }
    }
}

