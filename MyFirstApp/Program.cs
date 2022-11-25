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

            Human Michael = new Human("Michael", "Cooper", 38);
            Michael.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();


            Human humanNoAge = new Human("Luli");
            humanNoAge.IntroduceMyself();

            Human humanFirstLast = new Human("Alli", "Cooper");
            humanFirstLast.IntroduceMyself();

            Human humanFirstOnly = new Human("Legend", "Cooper", 3);
            humanFirstOnly.IntroduceMyself();

        }
    }
}