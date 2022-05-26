using System;
using System.Collections.Generic;

namespace exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter few numbers separated by hypen: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var element in input.Split('-'))
                numbers.Add(Convert.ToInt32(element));

            if(ContainsDuplicates(numbers))
                Console.WriteLine("Duplicates");
            
        }
        public static bool ContainsDuplicates(List<int> list)
        {
            var uniques = new List<int>();
            foreach (var number in list)
            {
            if (!uniques.Contains(number))
                uniques.Add(number);
            else
                return true;
            }
            return false;
        }
    }
}
