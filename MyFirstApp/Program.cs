using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Regular For Loop
            //for(int counter = 0; counter < 40; counter+=4)
            // {
            //     Console.WriteLine(counter + " is lower than 40");
            // }


            //Challenge - CountOut only Odd Numbers from 0 -20;
            for (int counter = 1; counter < 20; counter+=2)
            {
                
                Console.WriteLine(counter + " is an Odd number.");
            }

            Console.WriteLine("For loop is done");
            Console.Read();
        }
    }
}