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
        public string firstName;
        public string lastName;

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi I'm " + firstName + " "+ lastName);
        }
    }
}
