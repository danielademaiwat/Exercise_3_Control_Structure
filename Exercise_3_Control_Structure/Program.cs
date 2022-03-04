using System;


namespace Exercise_3_Control_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");

            String maxNum = Console.ReadLine();

            int y = int.Parse(maxNum);

            for (int i = 1; i <= y; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
// code created by Daniela De Maiwat BSIT-1