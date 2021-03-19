using System;
using System.Threading;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numSpaces = 0;

            

            string preSpaces = new String(' ', numSpaces);


            /*
             *   _____________________|\
             *  |                       \
             *  |                        \
             *  |                        /
             *  |_____________________  /
             *                        |/
             * 
             */

            string row1 = @" _____________________|\  ";
            string row2 = @"|                       \ ";
            string row3 = @"|                        \";
            string row4 = @"|                        /";
            string row5 = @"|_____________________  / ";
            string row6 = @"                      |/  ";


            bool forward = true;

            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine($"{ preSpaces}{ row1}");
                Console.WriteLine($"{ preSpaces}{ row2}");
                Console.WriteLine($"{ preSpaces}{ row3}");
                Console.WriteLine($"{ preSpaces}{ row4}");
                Console.WriteLine($"{ preSpaces}{ row5}");
                Console.WriteLine($"{ preSpaces}{ row6}");




                if (forward && i % 20 == 0)
                {
                    forward = false;
                }
                else if (!forward && i % 20 == 0)
                {
                    forward = true;
                }

                if (forward || numSpaces == 0)

                {
                    numSpaces++;
                }
                else
                {
                    numSpaces--;
                }

                preSpaces = new String(' ', numSpaces);

                Thread.Sleep(10);
                Console.Clear();

            }

        }
    }
}
