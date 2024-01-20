using System;


namespace lab1
{
    // single level
    class Question8
    {
        public void show()
        {
            Console.WriteLine("This is BAse class...");
        }


    }
    class Demo : Question8
    {
        public void Display()
        {
            Console.WriteLine("This is child class...");
        }
    }

    // mulilevel
    class Shape
    {
        public void drawshape()
        {
            Console.WriteLine("Drawing a shape..");
        }

    }
    class circle : Shape
    {
        public void drawCircle()
        {
            Console.WriteLine("Drawing circle....");
        }
    }
    class Rectange : circle
    {
        public void DrawRect()
        {
            Console.WriteLine("Drawing Reactnhle....");
        }
    }

}