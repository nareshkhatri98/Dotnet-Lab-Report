using System;

namespace lab1
{
     class Question7
    {
        private string name;
        private int age;

       public Question7()
        {
            Console.WriteLine("this is default Constructor..");
        }
        public Question7( string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine($"Name is:{name}");
            Console.WriteLine($"Age is: {age} ");
        }
    }
}
