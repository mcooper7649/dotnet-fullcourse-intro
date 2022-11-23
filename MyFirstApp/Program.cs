using System;
namespace HellWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats the temperature like?");
            string userInput = Console.ReadLine();

            //int temperature = int.Parse(userInput);

            int temperature;

            int number;

            if (int.TryParse(userInput, out number))
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
                Console.WriteLine("Value entered, was no number. 0 set at temperature");
            }

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }

            else if (temperature == 10)
            {
                Console.WriteLine("It's 10 degree C outside.");
            }
            else if (temperature > 10 && temperature < 30)
            {
                Console.WriteLine("Cozy warm!");
            }
            else
            {
                Console.WriteLine("It's a day for shorts.");
            }

            Console.Read();
        }
    }
}