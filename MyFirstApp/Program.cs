using System;
namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //break
            //for(int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine(counter);
            //    if(counter == 3)
            //    {
            //        Console.WriteLine("At 3 we stop");
            //        break;
            //    }
            //  Console.Read();
            //}


            //continue
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("Now comes an odd number");
                    continue;
                }
                Console.WriteLine(counter);

            }
            Console.Read();
        }
    }
}