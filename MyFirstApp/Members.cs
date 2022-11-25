using System;
using System.Diagnostics;

namespace Members
{
    class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;


        //member - property -exposes jobTitle safely - properties start w/ Captital Letter

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member Method - Can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0} and my jobTitle is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 30000;
            jobTitle = "developer";
            Console.WriteLine("Object Created");
        }

        //member - finalizer -destructor

        ~Members()
        {
            //cleanup statements

            Console.WriteLine("Deconstuction of Members object");
            Debug.Write("Deconstruction of Members object");
        }
    }
}

