using System;
namespace Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of my class
            //an  instance of human
            Human denis = new Human();
            denis.firstName = "Denis";
            denis.lastName = "Test";
            denis.IntroduceMyself();

            Human Michael = new Human();
            Michael.IntroduceMyself();
        }
    }
}