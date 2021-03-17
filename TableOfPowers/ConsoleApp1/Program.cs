using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello";
            string string2 = "World";

            Console.WriteLine(myString + " " + string2 + "!");

            Console.WriteLine($"{myString} {string2}!");
            
            Console.WriteLine(String.Format("{0} {1}!", myString, string2));

        }
    }
}
