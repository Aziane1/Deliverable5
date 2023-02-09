/*
 * Author: Adam Aziane 
 * Description: The deliverable that creates an array and displays a random generator of 15 numbers and the sum is given to the user afterwards. 
 * Date: 02/09/2023
 */

using System;



namespace Deliverable5
{
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random(); // Standard procedure for random number generator 
            int[] myarray= new int[array_len];
            for(int i = 0; i < array_len; i++)
            {
                myarray[i]= random.Next(5,15);
            }
            return myarray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item; 
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Boolean done = false;

            while (!done)
            {



                Console.WriteLine("Enter an integer between 5 and 15 ");
                try
                {

                    while (true)
                    {
                        int input = int.Parse(Console.ReadLine());

                        int[] samplearray = random_array(input);

                        if (input >= 5 && input <= 15)
                        {
                            Console.WriteLine("The element in the random array are: ");
                            foreach (int element in samplearray)
                            {
                                Console.Write(element + " ");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("The sum is: " + sum(samplearray));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error!!! Integers need to be between 5 and 15!");
                        }
                    }
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Function needs to have integers in the range of 5 and 15 only! ");
                }
            }
        }
    }
}