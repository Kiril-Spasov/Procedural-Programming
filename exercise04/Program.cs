using System;

namespace exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by space: ");
            var input = Console.ReadLine();

            Console.WriteLine(PascalCase(input));

        }
        public static string PascalCase(string words)
        {
            if (string.IsNullOrWhiteSpace(words))
                return "";

                var variableName = "";
            foreach (var word in words.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }
            return variableName;
        }
    }
}
