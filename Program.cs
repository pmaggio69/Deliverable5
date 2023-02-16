// Author: Patrick Maggio
// Created: 2/16/23
// Project Description: Create methods that allow for a random array to be created and summed
using System.Diagnostics.CodeAnalysis;
using System;

namespace Methods_Application
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++) 
            {
                MyArray[i] = random.Next(10,50);
            }
            return MyArray;
        }
        static int sum(int[] array) 
        { 
            int sum = 0;
            foreach(int item in array)
            {
                sum= sum+item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an interger between 5 and 15");
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input >=5 &&  input <= 15)
                {
                    int[] sampleArray = random_array(input);

                    foreach (int element in sampleArray)
                    {
                        Console.WriteLine(element + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(random_array(input)));
                }
                else
                {
                    Console.WriteLine("Please enter an interger bweteen 5 and 15");
                }

            }
            catch (Exception) 
            { 
                Console.WriteLine("Please enter an interger"); 
            }

        }
    }
}