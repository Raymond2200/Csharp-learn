using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is how an object of a class is created
            Human denis = new Human();

            denis.firstName = "Denis";

            denis.IntroduceMyself();

            Human michael = new Human();

            michael.firstName = "Michael";

            michael.IntroduceMyself();
        }
    }
}
