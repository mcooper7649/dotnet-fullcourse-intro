using System;
namespace HellWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            temperature += 10;

            //stateOfMatter = temperature < 0 ? "solid" : "liquid";


            //Challenge - add the gas stae of matter to the options

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

                Console.WriteLine("State of Matter is {0}", stateOfMatter);
            Console.ReadKey();
        }
    }
}