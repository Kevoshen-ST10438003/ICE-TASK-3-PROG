using System.Drawing;

namespace Shape_Area_Calculator_ICE_3
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("========================================================");
            Console.WriteLine ("**************** SHAPE AREA CALCULATOR******************");
            Console.WriteLine("========================================================");
            Console.WriteLine();

            // DIFFERENT VALUES CAN BE INPUT TO GET DIFFERENT DESIRED ANSWERS

            Rectangle rect = new Rectangle("Rectangle", 40, 10);
            Circle circle = new Circle("Circle", 7);

            rect.Display();
            Console.WriteLine();
            circle.Display();

            Console.ReadKey();
        }
    }
}
