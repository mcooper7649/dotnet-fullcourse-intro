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
            //for (int counter = 1; counter < 20; counter+=2)
            //{

            //    Console.WriteLine(counter + " is an Odd number.");
            //}

            //Console.WriteLine("For loop is done");
            //Console.Read();


            //do while loop
            //int lenghtOfText = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.WriteLine("Please enter the name of a friend");
            //    string nameOfFriend = Console.ReadLine();
            //    int currentLength = nameOfFriend.Length;
            //    lenghtOfText += currentLength;
            //    wholeText += nameOfFriend; 
            //} while (lenghtOfText < 20);
            //Console.WriteLine("Thanks that was enough.");
            //Console.Read();


            //while loop
            //    int counter = 0;
            //    while (counter < 10)
            //    {
            //        Console.WriteLine(counter);
            //        Console.ReadLine();
            //        counter++;
            //    }
            //    Console.Read();
            //}

            string students = "";
            int numStudents = 0;

            while (students.Equals(""))
            {
                Console.WriteLine("Hit Enter if a student has been hopped on the bus. Hit any other key when no more students to board.");
                students = Console.ReadLine();
                numStudents++;
                Console.WriteLine("Current count is {0}", numStudents);
            }
            Console.WriteLine("{0} people are inside the bus. Press Enter to close the program", numStudents);
            Console.Read();
        }
    }
}