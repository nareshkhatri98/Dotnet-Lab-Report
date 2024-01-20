using System;
namespace lab1
{
    class Question1
    {
        //properties
        public String FirstName{ get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        //constructor
        public Question1( string firstname , string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }
        // method
        public void Dispaly()
        {
            Console.WriteLine($"Name  {this.FirstName} {this.LastName}");
            Console.WriteLine($"Age: {this.Age} your old");
        }
    }
}
