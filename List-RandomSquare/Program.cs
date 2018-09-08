using System;
using System.Collections.Generic;

namespace List_RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random numbers do you want to be generated?");
            int numOfRandNums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entering the first number, at do you want the range of these numbers to be (ex. 1 to 10 : first number being 1)");
            int firstNumOfRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now Enter the second number (ex. 1 to 10 : second number being 10)");
            int secondNumOfRange = Convert.ToInt32(Console.ReadLine());

            var rand = new Random();
            var listOfRandomNumbers = new List<int>();


            for (int i = numOfRandNums; i > 0; i--)
            {
                // for each iteration I want to generate a random number inside the range
                var randomNum = rand.Next(firstNumOfRange, secondNumOfRange);
                // add randomly generated number to the list
                listOfRandomNumbers.Add(randomNum);
                // return the list
                Console.WriteLine(randomNum);
            }

            var listOfSquaredNumbers = new List<double>();

            foreach (var num in listOfRandomNumbers)
            {
                // get the num and square it 
                var squaredNum = Math.Pow(num, 2);
                listOfSquaredNumbers.Add(squaredNum);
                Console.WriteLine(squaredNum);
            }

        }
    }
}
