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

		// constructor
		public Human(string firstName, string lastName, string eyeColor, int age) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.eyeColor = eyeColor;
			this.age = age;

		}

		//member
		public void IntroduceMyself()
		{
			Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
			Console.WriteLine("My eyes are {0} and i'm {1} years old", eyeColor, age);
		}

	}
}

