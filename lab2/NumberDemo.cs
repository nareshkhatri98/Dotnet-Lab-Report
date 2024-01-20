
using System;
namespace lab2
{

    // Define the interface Number
    interface Number
    {
        int Square(int x);
        int Cube(int x);
    }

    // Implement the interface in the NumberDemo class
    class NumberDemo : Number
    {
        public int Square(int x)
        {
            return x * x;
        }

        public int Cube(int x)
        {
            return x * x * x;
        }
    }
}