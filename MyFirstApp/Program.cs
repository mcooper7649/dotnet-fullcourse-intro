using System;
 namespace HellWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats the temperature like?");
            string userInput = Console.ReadLine();



            int temperature = int.Parse(userInput);

            if(temperature < 10)
            {
                Console.WriteLine("Take the coat");
            }

            if (temperature == 10)
            {
                Console.WriteLine("It's 10 degree C outside.");
            }
            if (temperature > 10 && temperature < 30)
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