using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  The application prompts the user to enter values for the length and width of a classroom.
                The application displays the area and perimeter of that classroom.
                The application classifies the room as small (up to 250 square feet), medium(more than 250 but less than 650 square feet, or large(650 square feet or more.
                The application prompts the user to continue (keep measuring rooms!). */


            getPerimeter();

            static void getPerimeter()
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

                // Jeff uses "done" so he can write "!done" until it is switched.
                // so the initial bool of "done" is set to "false"

                bool userContinue = true;

                while (userContinue)
                {
                    double length;
                    double width;
                    double perimeter;
                    double area;
                    double volume;
                    double height = 10;

                    

                    Console.Write("\nEnter Length: ");
                    length = Double.Parse(Console.ReadLine());

                    Console.Write("Enter Width: ");
                    width = Double.Parse(Console.ReadLine());

                    perimeter = (2 * length) + (2 * width);
                    area = length * width;
                    volume = length * width * height;

                    Console.WriteLine("Area: " + area);
                    Console.WriteLine("Perimeter: " + perimeter);
                    Console.WriteLine("Volume: " + volume);

                    // small room is 250 square feet or less
                    // medium room is more than 250 but less than 650
                    // large is 650 sq ft or more



                    if (area > 250 && area < 650)
                    {
                        Console.WriteLine("This is a medium-sized room.");
                    }
                    else if (area <= 250)
                    {
                        Console.WriteLine("This is a small-sized room.");
                    }
                    else // (area >= 650)
                    {
                        Console.WriteLine("This is a large-sized room.");
                    }

                    Console.Write("\nConinue? (Y/N): ");
                    string answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    //Console.WriteLine(answer);

                    if (answer == "N")
                    {
                        userContinue = false;
                    }
                }

                Console.WriteLine("\nThank you for using the Room Detail Generator!");


            }
        }
    }
}
