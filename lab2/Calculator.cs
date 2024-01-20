using System;

namespace lab2
{
    abstract class Calculator
    {
        private int x;
        private int y;

        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void FindSum()
        {
            int sum = x + y;
            Console.WriteLine("The sum of the Two numbers is: " + sum);
        }

        public abstract void FindDiff(int x, int y);
        public abstract int FindMulti(int x, int y);
    }

    class Solution : Calculator
    {
        private int a;
        private int b;

        public Solution(int x, int y, int a, int b) : base(x, y)
        {
            this.a = a;
            this.b = b;
        }

        public override void FindDiff(int x, int y)
        {
            int diff = x - y;
            Console.WriteLine("The difference is: " + diff);
        }

        public override int FindMulti(int x, int y)
        {
            int multi = x * y;
            Console.WriteLine("The multiplication is " + multi);
            return multi;
        }

        public void CalcDiv()
        {
            if (b != 0)
            {
                int div = this.a /this.b;
                Console.WriteLine("The division is " + div);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
