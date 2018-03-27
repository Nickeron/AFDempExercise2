using System;
using System.Collections.Generic;

namespace AFDempExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(6);
            Square square2 = new Square(8);
            Square square3 = new Square(4);
            Square square4 = new Square(5);
            Square square5 = new Square(8);

            Rectangle rectangle1 = new Rectangle(20, 25);
            Rectangle rectangle2 = new Rectangle(4, 4);
            Rectangle rectangle3 = new Rectangle(5, 5);
            Rectangle rectangle4 = new Rectangle(17, 6);
            Rectangle rectangle5 = new Rectangle(10, 5);

            Console.WriteLine("Hi user! We have 5 Rectangles and 5 Squares.");
            Console.ReadKey();

            Console.WriteLine("\nNow, the 2nd square is supposed to be equal to the 5th.");
            Console.WriteLine($"And that's {square2.Equals(square5)}.");
            Console.ReadKey();

            Console.WriteLine("\nAlso, the 3rd rectangle is supposed to be equal to the 4th square.");
            Console.WriteLine($"And that's {rectangle3.Equals(square4)}.");
            Console.ReadKey();

            Console.WriteLine("\nNext, we make 2 lists filled with the above squares and rectangles");
            Console.ReadKey();

            List<Square> squareList = new List<Square>
            {
                square1,
                square2,
                square3,
                square4,
                square5
            };

            List<Rectangle> rectangleList = new List<Rectangle>
            {
                rectangle1,
                rectangle2,
                rectangle3,
                rectangle4,
                rectangle5
            };

            Console.WriteLine("\nThe square list contains:");
            PrintList(squareList);
            Console.ReadKey();

            Console.WriteLine("\nThe rectangle list contains:");
            PrintList(rectangleList);
            Console.ReadKey();

            Console.WriteLine("\nNow, we sort them! And so..");

            squareList.Sort();
            rectangleList.Sort();

            Console.WriteLine("\nThe square list contains:");
            PrintList(squareList);
            Console.ReadKey();

            Console.WriteLine("\nThe rectangle list contains:");
            PrintList(rectangleList);
            Console.ReadKey();

            Console.Write("\nPress any key to exit:");
            Console.ReadKey();
        }

        public static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine('\t' + item.ToString());
            }
        }
    }
}
