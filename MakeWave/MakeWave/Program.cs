using System;
using System.Threading;

namespace MakeWave
{
    class Program
    {
        static void Main(string[] args)
        {

            bool done = false;

            while (!done)
            {
                int i = 1;
                int whichRun = 1;
                int numDashes = 1;
                bool haveRowNums;

                Console.Write("How many rows of waves do you want? ");
                int stopNum = Int32.Parse(Console.ReadLine());

                Console.Write("With or without row numbers? ");
                string withOrWithout = Console.ReadLine();
                if (withOrWithout.ToLower() == "with")
                {
                    haveRowNums = true;
                }
                else
                {
                    haveRowNums = false;
                }



                while (i <= stopNum)
                {
                    if (whichRun == 1)
                    {
                        string dashes = new String('-', numDashes);
                        int dashLen = dashes.Length;
                        if (haveRowNums == true)
                        {
                            if (dashLen >= 16)
                            {
                                dashes = dashes + "\t" + i;
                            }
                            else if (dashLen <= 7)
                            {
                                dashes = dashes + "\t\t\t" + i;
                            }
                            else
                            {
                                dashes = dashes + "\t\t" + i;
                            }
                        }



                        Console.WriteLine(dashes);
                        if (numDashes % 20 == 0)
                        {
                            whichRun = 0;
                            numDashes--;
                        }
                        else
                        {
                            numDashes++;
                        }

                    }
                    else if (whichRun == 0)
                    {
                        string dashes = new String('-', numDashes);
                        int dashLen = dashes.Length;

                        if (haveRowNums == true)
                        {
                            if (dashLen >= 16)
                            {
                                dashes = dashes + "\t" + i;
                            }
                            else if (dashLen <= 7)
                            {
                                dashes = dashes + "\t\t\t" + i;
                            }
                            else
                            {
                                dashes = dashes + "\t\t" + i;
                            }
                        }

                        Console.WriteLine(dashes);

                        if (numDashes % 20 == 0)
                        {
                            whichRun = 1;
                            numDashes++;
                        }
                        else
                        {
                            numDashes--;
                        }
                    }
                    Thread.Sleep(1);
                    i++;









                }

                Console.Write("Again? (Y/N) ");
                string answer = Console.ReadLine();
                if(answer.ToUpper() == "N")
                {
                    done = true;
                }
                Console.WriteLine(15 + " is the number");
            }
            
        }
    }
}
