using System;

namespace exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time: ");
            var input = Console.ReadLine();

            if (IsValidTime(input))
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Time is not valid");

            
        }
        public static bool IsValidTime(string time)
        {
            if (string.IsNullOrWhiteSpace(time))
                return false;

            var components = time.Split(':');
            if (components.Length != 2)
                return false;

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
