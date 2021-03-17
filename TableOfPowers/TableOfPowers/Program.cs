using System;

namespace TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt use to enter an integer
            // displays a table of squares and cubes from 1 to the value entered
            // application prompts the user to continue

            Console.WriteLine("Learn your squares and cubes!");

            bool userContinue = true;
            int userNum;


            while (userContinue)
            {

                bool valid = false;

                


                Console.Write("\nEnter an integer: ");
                userNum = Int32.Parse(Console.ReadLine());
                if (userNum <= 1290 && userNum > 0)
                {
                    Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
                    Console.WriteLine("=======\t\t=======\t\t======");

                    for (int i = 1; i <= userNum; i++)
                    {
                        int squared = i * i;
                        int cubed = i * i * i;

                        //string sqString = Convert.ToString(squared);
                        //string cubeString = Convert.ToString(cubed);

                        string s = String.Format("{0, 7}\t\t {1, 6} \t {2, 5}", i, i*i*i, cubed);
                        //Console.WriteLine(i + "\t\t" + squared + "\t\t" + cubed);
                        Console.WriteLine(s);

                    }

                    Console.Write("\nContinue? (Y/N?): ");
                    string userAnswer = Console.ReadLine();
                    if (userAnswer == "N")
                    {
                        userContinue = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }



                
            }


        }
    }
}
