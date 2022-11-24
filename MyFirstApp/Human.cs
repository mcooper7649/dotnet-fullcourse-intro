using System;
namespace Classes__Basics
{
	//This class is a blueprint for a datatype

	//Challenge
	//Create a public variable lastname of type string
	//change the IntroduceMyself method, so it tells the whole name.
	//Create two objects with full information about themself - firstname and lastname

	class Human
	{
		//Member Variable
		public string firstName = "Michael";
		public string lastName = "Cooper";

		//member
		public void IntroduceMyself()
		{
			Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
		}

	}
}

