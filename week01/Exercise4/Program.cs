using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>();

        //instruction
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //append numbers entered in the list
        int num = -1;
        int total = 0;
        float avg;
        int largestNumber = -99999999;

        while (num != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                myList.Add(num);
            }
            else if (num == 0 && myList.Count >= 1)
            {
                foreach (int item in myList)
                {
                    total = total + item;
                    if (item > largestNumber)
                    {
                        largestNumber = item;
                    }
                }
                Console.WriteLine($"The sum is: {total}");

                //the average
                avg = ((float)total)/myList.Count;
                Console.WriteLine($"The average is: {avg}");
                //the largest number
                Console.WriteLine($"The largest number is: {largestNumber}");
                
            }
        }
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
    }
}