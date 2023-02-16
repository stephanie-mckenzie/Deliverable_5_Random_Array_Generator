﻿/*
 Name: Stephanie McKenzie
 Date: February 16, 2023
 Description: Testing Methods (C#)

Notes: I set up the Array Methods 1 & 2, and I have a try/catch to make sure a number is entered. 
The if/else statements either execute the code or gives an error message.

*/

namespace Deliverable_5
{
    class Program
    {
        static int[] array_randomizer(int array_length)
        {
            Random random= new Random();
            int[] ArrayMethod1 = new int[array_length];
            for (int i = 0; i< array_length; i++)
            {
                ArrayMethod1[i] = random.Next(10, 50);
            }
            return ArrayMethod1;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
            static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter an integer between the numbers 5 and 15.");
            try
            { 
                int inputnumber = int.Parse(Console.ReadLine());

                if ((inputnumber >= 5) &  (inputnumber <= 15))
                {
                    int[] ArrayMethod1 = array_randomizer(inputnumber);
                    Console.Write("The random elements that have been populated for your array are: ");
                    foreach (int i in ArrayMethod1)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is : " + sum(ArrayMethod1));
                }
                else
                {
                    Console.WriteLine("Only integers between 5 & 15 are accepted.");
                    Console.WriteLine("Press any key to exit the program.");
                }                
            }
            catch
            {
                Console.WriteLine("Invalid user input. Only INTEGERS accepted. Press any key to close the program.");
                Console.ReadKey(true);
            }   
            
        }
    }
}