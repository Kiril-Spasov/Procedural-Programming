using System;
using System.Collections.Generic;

namespace exercise01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] elements;

            Console.WriteLine("Enter a few numbers separated by hypen");
            var input = Console.ReadLine();

            elements = input.Split('-');

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var message = IsConsecutiveList(numbers) ? "Consecutive" : "Not consecutive";
            Console.WriteLine(message);
        }
        public static bool IsConsecutiveList(List<int> list)
        {
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }
            return true;
        }
    }
}