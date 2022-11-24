using System;
namespace Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of my class
            //an  instance of human
            Human denis = new Human("Denis", "Test", "brown", 33);
            denis.IntroduceMyself();

            Human Michael = new Human("Michael", "Cooper", "hazel", 38);
            Michael.IntroduceMyself();
        }
    }
}