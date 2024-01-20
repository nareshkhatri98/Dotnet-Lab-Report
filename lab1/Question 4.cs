using System;
namespace lab1
{
     class Question_4
    {
        private int num1;
        private int num2;
         
        public void setCalc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void calcSum()
        {
            int sum =this.num1 +this.num2;
            Console.WriteLine("Sum is :"+sum);
        }
        public int calcMulti()
        {
            return num1 * num2;
        }

        public void calcDifference()
        {
            int diff = num1 - num2;
            Console.WriteLine("Difference is : " +diff);
        }

    }
}
