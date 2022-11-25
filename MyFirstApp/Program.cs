using System;
namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 10;
            grades[3] = 15;
            grades[4] = 17;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);


            string input = Console.ReadLine();
            // Assign value to array grades at index 0;
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            //Another way to initialize
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //Third way of initializing an array
            int[] gradesOfMathStudentB = new int[] { 20, 13, 12, 8, 6 };


            Console.WriteLine("length of gradesOfMathStudentA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();

        }

    }

}
