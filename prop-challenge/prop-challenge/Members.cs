using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prop_challenge
{
    class Members
    {
        //member private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000; 

        // member public field
        public int age;

        public string Jobtitle
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

        // create member method- can be called from other classes.

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0} and my job title is {1} and I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is " + salary);
        }

        // member constructor

        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object Created");
        }

        // member deconstructor only one per class
        ~ Members ()
        {
            Console.WriteLine("Deconstruction of object");
        }

    }

}
