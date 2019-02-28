using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            Random r = new Random();
            Coordinate cor = new Coordinate();

            double[,] array = new double[input, 2];
            int a = array.Length - input;
            int counter = 0;

            for (int i = 0; i < a; ++i)
            {
                Coordinate random = new Coordinate(r);
                array[i, 0] = random.X();
                array[i, 1] = random.Y();
                Console.WriteLine($"X: {random.X()} \nY: {random.Y()}");
                Console.WriteLine($"\nHypotenuse: {cor.Hypotenuse(random.X(), random.Y())}");

                if (cor.Hypotenuse(random.X(), random.Y()) <= 1)
                {
                    counter++;
                }

                double coord = 0;
                double length = a;
                double total = counter;
                coord += total / length;
                double coordTotal = coord * 4;

                double diff = Math.Abs(coordTotal - Math.PI);
                Console.WriteLine($"Difference: {diff}");
                Console.ReadLine();
            }

        }

    }
}
