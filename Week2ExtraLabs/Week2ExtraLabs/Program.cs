using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Week2ExtraLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool done = false;
            //while (!done)
            //{
            //ADDITIONAL EXERCISES  

            // Exercise 1           

            //Console.WriteLine("\nExercise 1");

            //Console.Write(">>Enter some text: <<" );
            //string userString = Console.ReadLine();

            //Console.WriteLine($">>{userString}");

            //// Exercise 2

            //Console.WriteLine("\nExercise 2 (Enter 52 to get 53)");

            //Console.Write(">>Enter a number: <<");
            //int userNum = Int32.Parse(Console.ReadLine());

            //Console.WriteLine($">>{userNum + 1}");

            //// Exercise 3

            //Console.WriteLine("\nExercise 3 (Enter 17.3 to get 17.8)");

            //Console.Write(">>Enter a number: <<");
            //double userNum2 = Double.Parse(Console.ReadLine());

            //Console.WriteLine($">>{userNum2 + .5}");

            //// Exercise 4

            //Console.WriteLine("\nExercise 4 (Enter 12.2 and 17.3 to get 29.5)");

            //Console.Write(">>Enter a number: <<");
            //double userNum3 = Double.Parse(Console.ReadLine());
            //Console.Write(">>Enter another number: <<");
            //double userNum4 = Double.Parse(Console.ReadLine());

            //Console.WriteLine($">>The sum is {userNum3 + userNum4}");

            //// Exercise 5

            //Console.WriteLine("\nExercise 5 (Enter 10.2 and 13.4 to get 136.68)");

            //Console.Write(">>Enter a number: <<");
            //double userNum5 = Double.Parse(Console.ReadLine());
            //Console.Write(">>Enter another number: <<");
            //double userNum6 = Double.Parse(Console.ReadLine());

            //Console.WriteLine($">>The product is {userNum5 * userNum6}");

            //// Exercise 6

            //Console.WriteLine("Exercise 6");

            //bool done = false;

            //do
            //{
            //    Console.WriteLine(">>Hello, World!");
            //    Console.Write("Would you like to continue (y/n)? <<");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }

            //} while (!done);

            // Exercise 9

            //Console.WriteLine("\nExercice 9");
            //string[] languages = { "English", "Dutch", "French", "German", "Spanish" };
            //Console.Write("Enter a language: ");
            //string userLang = Console.ReadLine();

            //int userOption = Array.IndexOf(languages, userLang) + 1;

            //switch (userOption)
            //{
            //    case 1:
            //        Console.WriteLine("Hello, World!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hallo Wereld");
            //        break;
            //    case 3:
            //        Console.WriteLine("Bonjour le monde!");
            //        break;
            //    case 4:
            //        Console.WriteLine("Hallo Welt!");
            //        break;
            //    case 5:
            //        Console.WriteLine("Hola Mundo!");
            //        break;
            //    default:
            //        Console.WriteLine("You entered an invalid language");
            //        break;

            //}

            // Exercise 10

            //bool done = false;

            //while (!done)
            //{
            //    Console.Write("Enter you height in inches: ");
            //    double userHeight = Double.Parse(Console.ReadLine());
            //    if (userHeight < 54)
            //    {
            //        Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {Math.Round(54 - userHeight,1)} more inches");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Great, you can ride the Raptor!");
            //    }

            //    Console.Write("Would you like to continue (y/n)? ");
            //    string userAns = Console.ReadLine();

            //    if (userAns == "n")
            //    {
            //        done = true;
            //    }
            //}

            // Exercise 11 & 12

            //bool done = false;

            //while (!done)
            //{
            //    // for 11
            //    //for (int i = 0; i <= 9; i++)

            //    // for 12
            //    for (int i = 9; i >= 0; i--)
            //    {
            //        Console.Write(i + " ");
            //    }

            //    Console.Write("\nWould you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }

            //}


            // Exercise 13

            //bool done = false;

            //while (!done)
            //{

            //    Console.Write("Enter a number: ");
            //    int userNum = Int32.Parse(Console.ReadLine());
            //    for (int i = 0; i <= userNum; i++)
            //    {
            //        Console.Write(i + " ");
            //    }

            //    Console.Write("\nWould you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }
            //}

            // Exercise 14

            //bool done = false;

            //while (!done)
            //{

            //    Console.Write("Enter a number: ");
            //    int userNum = Int32.Parse(Console.ReadLine());
            //    for (int i = 0; i <= userNum; i++)
            //    {
            //        Console.Write(i * i + " ");
            //    }

            //    Console.Write("\nWould you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }
            //}

            // Exercise 15

            //bool done = false;

            //while (!done)
            //{

            //    Console.Write("Enter a number: ");
            //    int userNum = Int32.Parse(Console.ReadLine());
            //    for (int i = 0; i <= userNum; i++)
            //    {
            //        Console.Write(i * i * i + " ");
            //    }

            //    Console.Write("\nWould you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }
            //}

            // Exercise 16

            //for (int i = 1; i <= 10; i++)
            //{
            //    string stars = new string('*', i);
            //    Console.WriteLine(stars);
            //}

            //// Exercise 17

            //int triHeight = 10;
            //int x = triHeight - 1;

            //for (int i = 1; i <= triHeight; i++)
            //{
            //    string starSpaces = "";

            //    for (int y = 1; y <= i; y++)
            //    {
            //        starSpaces = starSpaces + "*" + " ";
            //    }
            //    //string stars = new String('*', i);
            //    //string spaces = new String(' ', i);

            //    string preSpaces = new String(' ', x);
            //    x -= 1;
            //    //string starSpaces = stars + spaces;
            //    Console.WriteLine(preSpaces + starSpaces);
            //}

            //string preSpaces = new String(' ', numSpaces);


            //   *  
            //  * *  
            // * * *
            //* * * *

            // Exercise 18

            //Console.Write("Enter a number: ");
            //int userNum = Int32.Parse(Console.ReadLine());

            //int sumNum = 0;

            //for (int i = 1; i <= userNum; i++)
            //{
            //    sumNum += i;
            //}
            //Console.WriteLine(sumNum);

            // Exercise 19

            //Console.Write("Enter a number: ");
            //int firstNum = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //int secondNum = Int32.Parse(Console.ReadLine());

            //int sumNum = 0;

            //for (int i = firstNum; i <= secondNum; i++)
            //{
            //    sumNum += i;
            //}

            //Console.WriteLine($"the sum of all the numebrs from {firstNum} to {secondNum} is {sumNum}.");

            // Exercise 20

            //Console.Write("Enter a number: ");
            //int userNum = Int32.Parse(Console.ReadLine());

            //Console.WriteLine($"The product of {userNum}, {userNum - 1}, and {userNum - 2} is {userNum * (userNum - 1) * (userNum - 2)}");

            // Exercise 21


            //List<string> myList = new List<string>();

            //while (!done)
            //{

            //    Console.Write("Enter a word: ");
            //    string userWord = Console.ReadLine();

            //    myList.Add(userWord);




            //    Console.Write("Would you like to enter another word? ");


            //    //Console.Write("\nWould you like to continue (y/n)? ");


            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }




            //}

            //myList.ToArray();

            //string[] myArray = myList.ToArray();


            //for (int i = 0; i <= myArray.GetUpperBound(0); i++)
            //{
            //    Console.Write(myArray[i]);
            //    if (i == myArray.GetUpperBound(0))
            //    {
            //        Console.Write(".\n");
            //    }
            //    else
            //    {
            //        Console.Write(" ");
            //    }
            //}

            //Console.WriteLine("Goodbye! Have a beautiful time!");

            //Console.WriteLine(myArray[0]);


            // Exercise 22

            //bool done = false;
            //while (!done)
            //{

            //    int num1;
            //    int num2;
            //    int num3;

            //    Console.Write("Enter a number: ");
            //    num1 = Int32.Parse(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    num2 = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine($"Your range is {num1}-{num2}.");
            //    Console.Write("\nEnter a number to verify it's in the range: ");
            //    num3 = Int32.Parse(Console.ReadLine());

            //    if (num3 >= num1 && num3 <= num2)
            //    {
            //        Console.WriteLine($"{num3} is in the range.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num3} is outside the range.");
            //    }

            //    Console.Write("Would you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();

            //    if (ans == "n")
            //    {
            //        done = true;
            //    }
            //}
            //Console.WriteLine("Goodbye!");

            // Exercise 23


            //bool done = false;
            //while (!done)
            //{
            //    Console.Write("Enter some text: ");
            //    string userString = Console.ReadLine();

            //    Console.WriteLine($"The first ten characters were: {userString.Substring(0, 10)}");



            //    Console.Write("Would you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();

            //    if (ans == "n")
            //    {
            //        done = true;
            //    }
            //}


            // Exercise 24

            //bool done = false;
            //while (!done)
            //{

            //    Console.Write("Enter some text: ");
            //    string userString = Console.ReadLine();
            //    int strLen = userString.Length;
            //    int startIndex = 0;
            //    int numOfChars = 10;
            //    if (strLen > 10)
            //    {
            //        startIndex = strLen - 10;
            //    }
            //    else
            //    {
            //        numOfChars = strLen;
            //    }




            //    Console.WriteLine($"The last ten characters were: {userString.Substring(startIndex, numOfChars)}");








            //    Console.Write("Would you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();

            //    if (ans == "n")
            //    {
            //        done = true;
            //    }
            //}
            //Console.WriteLine("Goodbye!");

            // Exercise 25


            //bool done = false;
            //while (!done)
            //{
            //    Console.Write("Enter a sentence: ");
            //    string userSentence = Console.ReadLine();

            //    string[] sentenceArray = userSentence.Split(' ');
            //    for (int i = 0; i <= sentenceArray.GetUpperBound(0); i++)
            //    {
            //        Console.WriteLine(sentenceArray[i]);
            //    }

            //    Console.Write("Would you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }
            //}

            // Exercise 26

            //bool done = false;
            //while (!done)
            //{

            //    Console.Write("Enter some text: ");
            //    string text = Console.ReadLine();

            //    text = text.ToLower();
            //    int numOfVowels = 0;

            //    for (int i = 0; i <= text.Length - 1; i++)
            //    {
            //        string letter = Convert.ToString(text[i]);
            //        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            //        {
            //            numOfVowels += 1;
            //        }
            //    }

            //    Console.WriteLine($"There are {numOfVowels} vowels.");

            //    Console.Write("Would you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }


            //}

            // Exercise 27

            //bool done = false;
            //while (!done)
            //{

            //    Console.Write("Enter some text: ");
            //    string text = Console.ReadLine();

            //    text = text.ToLower();
            //    int numOfCons = 0;

            //    Regex rx = new Regex(@"^[b-df-hj-np-tv-z]$");

            //    for (int i = 0; i <= text.Length - 1; i++)
            //    {
            //        string letter = Convert.ToString(text[i]);
            //        if (rx.IsMatch(letter))
            //        {
            //            numOfCons += 1;
            //        }
            //    }

            //    Console.WriteLine($"There are {numOfCons} consonants.");

            //    Console.Write("Would you like to continue (y/n)? ");
            //    string ans = Console.ReadLine();
            //    if (ans == "n")
            //    {
            //        done = true;
            //    }


            //}

            // Exercise 28

            //Console.Write("Enter some text: ");
            //string text = Console.ReadLine();
            ////text = text.ToLower();

            //Regex rx = new Regex($"^[aeiouAEIOU]$");

            //for (int i = 0; i <= text.Length - 1; i++)
            //{
            //    string singleLetter = Convert.ToString(text[i]);
            //    if (rx.IsMatch(singleLetter))
            //    {
            //        //Console.WriteLine($"{singleLetter} is a vowel");
            //        int letterIndex = i;
            //        text = text.Remove(i, 1);
            //    }


            //}

            //Console.WriteLine(text);

            // Exercise 29

            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            //text = text.ToLower();

            string[] sentenceArray = text.Split(' ');

            Regex rx = new Regex($"^[aeiouAEIOU]$");
            List<string> myList = new List<string>();

            // This is looping through the elements in the array
            for (int i = 0; i <= sentenceArray.Length - 1; i++)
            {
                string singleWord = sentenceArray[i];
                
                //This is looping through the letters in the single word
                for (int n = 0; n <= singleWord.Length - 1; n++)
                {
                    // This is using the index to get just a single letter
                    string singleLetter = Convert.ToString(singleWord[n]);
                    if (rx.IsMatch(singleLetter) && n != 0 && n != singleWord.Length - 1)
                    {
                        //Console.WriteLine($"{singleLetter} is a vowel");
                        
                        singleWord = singleWord.Remove(n, 1);
                        
                    }
                    
                }
                myList.Add(singleWord);


            }
            string[] myArray = myList.ToArray();


            for (int x = 0; x <= myArray.Length - 1; x++)
            {
                if (x == myArray.Length - 1)
                {
                    Console.Write(myArray[x]+"\n");
                }
                else
                {
                    Console.Write(myArray[x] + " ");
                }
                    
            }


            Console.Write("Enter some text: ");
            string text1 = Console.ReadLine();

            for (int k = text1.Length - 1; k >= 0; k--)
            {
                Console.Write(text1[k]);
            }
            Console.WriteLine("");


        }




    }
}
