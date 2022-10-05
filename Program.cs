using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossMultipleCoins(3);
            Names();
        }

        public static Array RandomArray()
        {
            Random rand = new Random();
            int[] arr = new int[10];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5, 26);
                sum += arr[i];
            }
            int max = arr[0];
            int min = arr[0];
            foreach (int number in arr)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"The max is {max}");
            Console.WriteLine($"The min is {min}");
            Console.WriteLine($"The sum is {sum}");
            return arr;
        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int toss = rand.Next(0, 2);
            if (toss == 0)
            {
                string result = "Heads";
                Console.WriteLine(result);
                return result;
            }
            else
            {
                string result = "Tails";
                Console.WriteLine(result);
                return result;
            }
        }

        public static double TossMultipleCoins(int num)
        {
            double total = num;
            double headsCount = 0;
            while (num > 0)
            {
                string result = TossCoin();
                if (result == "Heads")
                {
                    headsCount++;
                }
                num--;
            }
            double ratio = headsCount / total;
            return ratio;
        }

        public static List<string> Names()
        {
            List<string> namesList = new List<string>() { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            List<string> shuffledList = new List<string>();
            List<string> longNameList = new List<string>();
            Random rand = new Random();
            int numOfNames = namesList.Count;
            while (numOfNames > 0)
            {
                int randomIndex = rand.Next(0, numOfNames);
                shuffledList.Add(namesList[randomIndex]);
                namesList.RemoveAt(randomIndex);
                numOfNames--;
            }
            foreach (string name in shuffledList)
            {
                Console.WriteLine(name);
            }
            foreach (string name in shuffledList)
            {
                if (name.Length > 5)
                {
                    longNameList.Add(name);
                }
            }
            return longNameList;
        }
    }
}
