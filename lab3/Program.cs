using System;
namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question7
           OwnException obj = new OwnException();
            try
            {
                obj.sendYourage(14);
            }
            catch (AgeException a)
            {
                Console.WriteLine(a);
            }






            //Question 4
            //try
            //{

            //    Console.Write("Enter a first number: ");
            //    string number = Console.ReadLine();
            //    Console.Write("Enter a second number: ");
            //    string num1 = Console.ReadLine();


            //    int number1 = int.Parse(number);
            //    int number2 = int.Parse(num1);    

            //    int result = number1 / number2;

            //    Console.WriteLine("Result of division: " + result);
            //}
            //catch (FormatException ex)
            //{

            //    Console.WriteLine("FormatException: " + ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine("DivideByZeroException: " + ex.Message);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Exception: " + ex.Message);
            //}
            //finally
            //{

            //    Console.WriteLine("Finally block executed.");
            //}

            //Console.ReadKey();


            //question5

            //    try
            //    {

            //        Console.WriteLine("Outer try block - Start");


            //        int[] numbers = { 1, 2, 3 };
            //        Console.WriteLine("Attempting to access an element outside the array bounds: " + numbers[5]);


            //        try
            //        {
            //            Console.WriteLine("Inner try block - Start");


            //            int result = DivideNumbers(10, 0);
            //            Console.WriteLine("Result of division: " + result);

            //            Console.WriteLine("Inner try block - End");
            //        }
            //        catch (DivideByZeroException innerEx)
            //        {
            //            Console.WriteLine("Caught DivideByZeroException in the inner try block: " + innerEx.Message);
            //        }

            //        Console.WriteLine("Outer try block - End");
            //    }
            //    catch (IndexOutOfRangeException outerEx)
            //    {

            //        Console.WriteLine("Caught IndexOutOfRangeException in the outer try block: " + outerEx.Message);
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Caught general Exception: " + ex.Message);
            //    }
            //    finally
            //    {

            //        Console.WriteLine("Finally block executed.");
            //    }

            //    Console.ReadKey();
            //}

            //static int DivideNumbers(int numerator, int denominator)
            //{

            //    return numerator / denominator;
            //}


            //    //question6
            //    try
            //{
            //    // Simulate a situation where an exception may occur
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine("Attempting to access an element outside the array bounds: " + numbers[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    // Catch and handle IndexOutOfRangeException
            //    Console.WriteLine("Caught IndexOutOfRangeException: " + ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    // Catch and handle DivideByZeroException
            //    Console.WriteLine("Caught DivideByZeroException: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    // Catch and handle any other exceptions
            //    Console.WriteLine("Caught general Exception: " + ex.Message);
            //}
            //finally
            //{
            //    // The code in the finally block will be executed regardless of whether an exception occurred or not
            //    Console.WriteLine("Finally block executed.");
            //}

            Console.ReadKey();

         


            
        }  
    }
}
