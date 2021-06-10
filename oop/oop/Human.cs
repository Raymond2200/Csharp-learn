using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    // this class is a blueprint for datatype
    class Human
    {

        // member variable
        private string firstName;
        private string lastName;

        // constructor

        public Human(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi I'm " + firstName + " "+ lastName);
        }
    }
}
