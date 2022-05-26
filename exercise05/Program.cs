using System;
using System.Collections.Generic;

namespace exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word: ");
            var input = Console.ReadLine();

            Console.WriteLine(VowelsCount(input));
        }

        public static int VowelsCount(string word)
        {
            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });

            var vowelsCount = 0;
            foreach (var character in word.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }
            return vowelsCount;
        }
    }
}
