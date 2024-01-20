using System;
namespace lab2
{
    class Question10
    {
        public virtual void calc1(int x, int y)
        {
            Console.WriteLine("The sum of two number is:" + (x + y));
        }
        public virtual void calc2(int x, int y, int z)
        {
            Console.WriteLine("Multiplication is " + (x * y * z));
        }
    }
    class Demo : Question10
    {
        public override void calc1(int x, int y)
        {
            base.calc1(x, y);
            Console.WriteLine("The difference is :" + (x - y));
        }
        public override void calc2(int x, int y, int z)
        {
            base.calc2(x, y, z);
            Console.WriteLine("The result is :" + (x + y * z));
        }
    }
}