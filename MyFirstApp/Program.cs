using System;
namespace HellWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 18:
                    Console.WriteLine("Old enough to party");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            Console.Read();

            if (age == 14)
            {
                Console.WriteLine("Too young to party in the club!");
            }
        else if (age == 18){
                Console.WriteLine("old enough to party!");

            }
        else
            {
                Console.WriteLine("How old are you?");
            }

            Console.Read();

        }
    }
}