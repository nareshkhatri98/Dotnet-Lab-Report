using System;
namespace lab2
{
    class Question9
    {
        private int reg;
        private String model;
        private String name;
        public  Question9(int reg, String model, String name)   
        {
            this.reg = reg;
            this.model = model;
            this.name = name;

        }
        public void Display()
        {
            Console.WriteLine("Registration is " + this.reg);
            Console.WriteLine("Model is " + this.model);
            Console.WriteLine("Name is " + this.name);
        }
    }
    class Bike : Question9
    {
        private string milege;
        private string speed;
        public Bike(string milege, string speed, int reg, string model, string name) : base(reg, model, name)

        {
            this.milege = milege;
            this.speed = speed;
        }

        public void DisplayBike()
        {
            Console.WriteLine("Milege is " + this.milege);
            Console.WriteLine("Speed is " + this.speed);

        }
    }
}
