
using System;
namespace lab3
{
    class AgeException : Exception
    {
        // if age is less than 16 throw your error..
        public AgeException(string s) : base(s)
        {
            Console.WriteLine("age cannot be less the 16..");
        }
    }
    class OwnException
    {
        public void sendYourage(int age)
        {
            if (age < 16)
            {
                //throw own exception
                throw new AgeException("age  can't be less tha 16");
            }
            else
            {
                Console.WriteLine("your are eligible  to participate");
            }
        }

    }
}
