using System;
namespace lab2
{
    interface IShape
    {
        void Draw(); 
    }
    interface IColor
    {
        void SetColor(string color); 
    }
    class Circle : IShape, IColor
    {
        private string color;
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
        public void SetColor(string color)
        {
            this.color = color;
            Console.WriteLine("Setting circle color to: " + color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Bike obj = new Bike("12", "120", 1, "2020", "apache");
            //obj.Display();
            //obj.DisplayBike();

            // Question 10
            //Question10 obj1 = new Question10();
            //obj1.calc1(12, 13);
            //obj1.calc2(3, 4, 7);


            //SalaryInfo employeeSalary = new SalaryInfo(101, "Bisham Thapa", 'M', "123 KTM Nepal", "Developer", 500000);
            //employeeSalary.DisplayDetails();
            //Console.WriteLine("-------------");
            //employeeSalary.CalcTax();

            //Question 12
            //Solution s1 = new Solution(12,12,12,12);
            //s1.FindSum();
            //s1.CalcDiv();
            //s1.FindDiff(12, 12);
            //s1.FindMulti(12, 12);
            //Question 13
            //solve solve = new solve();
            //int add = solve.add(12, 12);
            //int diff = solve.diff(12, 4);
            //Console.WriteLine("The Addition is: "+add);
            //Console.WriteLine("The Difference is: " +diff);

            // Question 14
            //NumberDemo obj = new NumberDemo();
            //int sqrt = obj.Square(12);
            //int cube =obj.Cube(3);
            //Console.WriteLine("The square of the number is: "+sqrt);
            //Console.WriteLine("The cube of the number is: " + cube);
            //Question 15
            Circle circle = new Circle();
            circle.Draw();
            circle.SetColor("Red");
            IShape shape = circle;
            shape.Draw();
            IColor color = circle;
            color.SetColor("Blue");
            Console.ReadKey();

        }
    }

}