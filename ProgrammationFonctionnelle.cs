using System;
using System.Collections.Generic;
using System.Linq;

namespace Ienumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateMeanOfArray();
        }

        public static void CalculateMeanOfArray()
        {
            Console.Write("Enter a frontier number: ");
            int frontierNumber = Convert.ToInt32(Console.ReadLine());
            double mean = ArrayMean(IntegersArray(), frontierNumber);
            Console.WriteLine($"Mean of the array for numbers inferior to {frontierNumber} is of {mean}.");
        }

       
        public static double ArrayMean(int[] integersArray, int frontierNumber)
        {
            List<int> integersList = integersArray.Where((x) => x <= frontierNumber).ToList();
            double sumList = integersList.Sum();
            int lengthList = integersList.Count();
            double mean = (double)sumList / lengthList;
            return mean;
        }

        public static int[] IntegersArray()
        {
            int[] integersArray = new int[50];
            int counter = 0;
            for (int i = 0; i < 50; i++)
            {
                integersArray[i] = counter;
                counter++;
            }
            return integersArray;
        }


    }
}
