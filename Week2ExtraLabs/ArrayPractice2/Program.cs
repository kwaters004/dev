using System;

namespace ArrayPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Hello", "my", "name", "is", "Kirk" };
            string[] myArray2 = new string[2];

            string[] myArray3 = (string[]) myArray.Clone();

            Console.WriteLine(myArray3[2]);

            myArray3[2] = "passion";

            for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            {

            }



        }
    }
}
