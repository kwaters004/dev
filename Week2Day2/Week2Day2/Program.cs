using System;

namespace Week2Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 10;
            //int twice = num % 3;
            //Console.WriteLine(twice);

            //string first = "George";
            //string last = "Washington";
            //last = last.ToUpper();

            //string last = Console.ReadLine().ToUpper();
            //Console.WriteLine(last);

            // This works
            // string full = first + " " + last;

            // but this is better
            //string full = $"Hello {first.ToUpper()} {last} {num + 3}";

            //.ToUpper();

            //Console.WriteLine(full);

            //bool done = false;
            //Console.WriteLine(done);


            //int favorite = 30;

            //while (favorite < 40)
            //{
            //    Console.WriteLine(favorite);
            //    favorite++;
            //}

            // This string has a length of 0
            //string myName = "";
            // This string doesn't have a length
            //string myName;

            //myName = "Kirk";
            //Console.WriteLine(myName);

            /* This is not an efficent way to do this
            
            int Student1 = 95;
            int Student2 = 80;
            int Student3 = 90;
            int Student4 = 100;
            int Student5 = 85;

            Console.WriteLine(Student1);
            Console.WriteLine(Student2);
            Console.WriteLine(Student3);
            Console.WriteLine(Student4);
            Console.WriteLine(Student5); */

            string[] StudentNames = { "Fred", "Julie", "Sam", "Sarah", "Jane" };
            int[] Students = { 95, 80, 90, 100, 85 };

            //Console.WriteLine(Students);
            //Console.WriteLine(Students.Length);

            int smarty = 0;
            int highestNum = 0;

            for (int i = 0; i < Students.Length; i++)
            {

                if (i == 0)
                {
                    highestNum = Students[i];
                }
                else if (Students[i] > highestNum)
                {
                    highestNum = Students[i];
                    smarty = i;
                }

                Console.WriteLine($"{StudentNames[i]} has a grade of {Students[i]}");
                //Console.WriteLine(smarty);
            }
            Console.WriteLine($"\nThe smartest student is {StudentNames[smarty]}.");
            Console.WriteLine("What a nerd...\n");

            int upper = Students.GetUpperBound(0);
            Console.WriteLine($"The upper bound of the Students array is {upper}");

            /*
            int q = 0;
            q = q + 1;
            q++;
            q += 2;
            q = q + 2;

            q = q - 1;
            */

            //int q = 0;
            // the post increment will still change the q variable, but it wont do it when setting the variable
            // put the increment on it's own line if you need to use it.
            //int r = q++;
            //int r = q += 1;
            //r = q;

            //Console.WriteLine(r);
            // this is a post increment
            //Console.WriteLine(q++);
            //Console.WriteLine(q);
            //q++;

            // this is a pre increment
            //++q;



            
        }
    }
}
