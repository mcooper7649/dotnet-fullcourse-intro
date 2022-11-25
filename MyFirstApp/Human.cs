using System;
namespace Classes__Basics
{

    //Challenge
    //Add two more member variables to Human. EyeColor and age
    //Adjust the contstructor, so it requires all of the four values to be used, when creating an object of Human.
    //Create two objects of type Human


    //This class is a blueprint for a datatype

    class Human
    {
        //Member Variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;



        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // constructor with just firstName
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //constructor with just firstName and Lastname
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;

        }



        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

        }

        //member
        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && eyeColor != null && firstName !=null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and my eyes are {2} and i'm {3} years old",firstName, lastName, eyeColor, age);

            }
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and my age is {2}", firstName, lastName, age);

            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);

            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}", firstName );

            }
        }

    }
}

