using System;

namespace ShapeArea
{

    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape would you like to find the area of?");
            Console.WriteLine("Please enter 'r' for rectangle or 'c' for circle or any other key for triangle.");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle.");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if (answer == "c") 
            {
                Console.WriteLine("Please enter the radius of the circle.");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }
            else
            {
                Console.WriteLine("Please enter the height of the triangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the the base of the triangle.");
                float width = float.Parse(Console.ReadLine());

                result = (height * width) /2;
            }

            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
    }
}