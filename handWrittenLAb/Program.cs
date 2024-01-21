using System;
using System.Runtime.InteropServices;
namespace handWrittenLAb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question1.
            //int integervalue = 10;
            //float floatvalue = 10.22f;
            //char charvalue = 'A';
            //string stringvlaue = "This is string";
            //bool boolvalue = false;
            //Console.WriteLine("The integer value is: " +integervalue);
            //Console.WriteLine("The float value is:"+floatvalue);
            //Console.WriteLine("The char value is: " +charvalue);
            //Console.WriteLine("The string value is: " +stringvlaue);
            //Console.WriteLine("The Boolean value is: " +boolvalue);

            //Question2.

            /*
           
            int positiveInteger = 123;

   
            int negativeInteger = -456;

            int hexadecimalLiteral = 0x1A3;

          
            int octalLiteral = Convert.ToInt32("76", 8);

            int binaryLiteral = 0b11011010;

            Console.WriteLine("Positive Integer Literal: " + positiveInteger);
            Console.WriteLine("Negative Integer Literal: " + negativeInteger);
            Console.WriteLine("Hexadecimal Representation: " + hexadecimalLiteral);
            Console.WriteLine("Octal Literal: " + octalLiteral);
            Console.WriteLine("Binary Literal: " + binaryLiteral);
            */

            //Question3
            /*
            float floatLiteral = 3.14f;    
            double doubleLiteral = 2.71828; 
            double exponentialLiteral = 6.022e23;

            bool trueLiteral = true;
            bool falseLiteral = false;

            char charLiteral = 'A';

            
            string stringLiteral = "Hello, \tWorld!\nThis is a new line.";

            Console.WriteLine("Float Literal: " + floatLiteral);
            Console.WriteLine("Double Literal: " + doubleLiteral);
            Console.WriteLine("Exponential Literal: " + exponentialLiteral);
            Console.WriteLine("Boolean True Literal: " + trueLiteral);
            Console.WriteLine("Boolean False Literal: " + falseLiteral);
            Console.WriteLine("Character Literal: " + charLiteral);
            Console.WriteLine("String Literal: " + stringLiteral);
            */
            //Question4

            /*
            int number = 10;
            double doublevalue = number;

            Console.WriteLine("The implicit  type casting...");
            Console.WriteLine("Integer value: "+number);
            Console.WriteLine("The Double value (after Type casting) is: " +doublevalue );
            Console.WriteLine("---------------------------------------");

            double explicitdoublevalue = 2.23;
            int explicitIntegerValue = (int)explicitdoublevalue;
            Console.WriteLine("The Explicit type casting...");
            Console.WriteLine("The Explicit double is :" +explicitdoublevalue);
            Console.WriteLine("The Explicit integer value(after type casting) is: " +explicitIntegerValue);
            */
            //Question5/
            /*
            int number1 = 4;
            int number2 = 2;
            Console.WriteLine("------Arithmetic operator ----------");
            Console.WriteLine("The addition is : " +(number1+number2));
            Console.WriteLine("The Difference is: " +(number1-number2));
            Console.WriteLine("The Multiply is: " +(number1*number2));
            Console.WriteLine("The division is: " +(number1 /number2));
            Console.WriteLine("The mode is: " +(number1%number2));

            Console.WriteLine("-----Increment and Decrement operator-----");
            int num = 12;
            Console.WriteLine("Before increment: " + num);
            num++;
            Console.WriteLine("After increment: "+num);

            num--;
            Console.WriteLine("After Decrement: " +num);

            Console.WriteLine("----comparison operator----");
            int x = 12; int y = 13;
            bool isEqual = (x == y);
            bool isNotEqual = (x != y);
            bool isGreaterThan = (x > y);
            bool isLessThan = (x < y);
            bool isGreaterOrEqual = (x >= y);
            bool isLessOrEqual = (x <= y);

           
            Console.WriteLine($"Is Equal: {isEqual}");
            Console.WriteLine($"Is Not Equal: {isNotEqual}");
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Greater or Equal: {isGreaterOrEqual}");
            Console.WriteLine($"Is Less or Equal: {isLessOrEqual}");



            Console.WriteLine("---Boolean Logical Operator-----");
            bool condition1 = true, condition2 = false;

            bool andResult = condition1 && condition2; 
            bool orResult = condition1 || condition2;  
            bool notResult = !condition1;  

         
            Console.WriteLine($"AND Result: {andResult}");
            Console.WriteLine($"OR Result: {orResult}");
            Console.WriteLine($"NOT Result: {notResult}");

            */

            //Question 6:
            /*
            int x = 5, y = 10, result;
            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);
            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);
            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);
            result = ~x;
            Console.WriteLine("Bitwise Complement: " + result);
            result = x << 2;
            Console.WriteLine("Bitwise Left Shift: " + result);
            result = x >> 2;
            Console.WriteLine("Bitwise Right Shift: " + result);
            

            
            */

            //Question 7:
            /*
            int number = 15;

            Console.WriteLine("-----Conditional Statements-------");

            // If Statement
            if (number > 10)
            {
                Console.WriteLine("Number is greater than 10");
            }

            // If...Else Statement
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            // If...Else If...Else Statement
            if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else
            {
                Console.WriteLine("Number is positive");
            }

            // Loops
            Console.WriteLine("---Loops---");

            // While Loop
            int i = 1;
            Console.WriteLine("-----------While Loop----");
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do-While Loop
            int j = 1;
            Console.WriteLine("----Do-While Loop-----");
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 5);

            // For Loop
            Console.WriteLine("-----For Loop-----");
            for (int k = 1; k <= 5; k++)
            {
                Console.WriteLine(k);
            }

            // For Each Loop
            Console.WriteLine("---For Each Loop----");
            int[] numbersArray = { 1, 2, 3, 4, 5 };
            foreach (int num in numbersArray)
            {
                Console.WriteLine(num);
            }
            */

            //Question8.
            /*
             // Taking String Input
        Console.Write("Enter your name: ");
        string Name = Console.ReadLine();

        // Taking Integer Input
        Console.Write("Enter the number: ");
        string Number = Console.ReadLine();

        // Convert the string to integer using int.TryParse
        if (int.TryParse(Number, out int userInputInteger))
        {
            // Displaying the entered values
            Console.WriteLine("Your name is: " +Name);
            Console.WriteLine("The entered number is: " + Number);
        }
        else
        {
            Console.WriteLine("\nInvalid integer input. Please enter a valid integer.");
        }
            */
            //Question 9:
            /*

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            // Convert the string to integer using int.TryParse
            if (int.TryParse(userInput, out int number))
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is a composite number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Pause to see the result
            Console.ReadLine();
        }

        // Function to check if a number is prime
        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        */

            //Question10.
            /*
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            // Convert the string to integer using int.TryParse
            if (int.TryParse(userInput, out int number))
            {
               if(number %2 ==0)
                {
                    Console.WriteLine($"{number} is even");
                }
                else
                {
                    Console.WriteLine($"{number} is odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            */
            //Question 11.
            /*
            Console.WriteLine("Prime numbers between 1 and 100:");

            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }

            // Pause to see the result
            Console.ReadLine();
        }

        // Function to check if a number is prime
        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
            */

            /*
            //Question 12.

            Console.WriteLine("Even numbers between 300 and 500:");

            for (int i = 300; i <= 500; i++)
            {
                if (IsEven(i))
                {
                    Console.Write(i + " ");
                }
            }

            // Pause to see the result
            Console.ReadLine();
        }

        // Function to check if a number is even
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        
           */

            /*
            //Question 13

            int n = 10;
            int sum = Sum(n);

            Console.WriteLine($"Sum of the first {n} natural numbers: {sum}");

            // Pause to see the result
            Console.ReadLine();
        }

        // Function to calculate the sum of first n natural numbers
        static int Sum(int n)
        {
            return (n * (n + 1)) / 2;

        */


            //Question 14.
            /*
            int[] subjectMarks = new int[5];

            // Read marks for each subject
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate total marks and percentage
            int totalMarks = 0;
            foreach (int marks in subjectMarks)
            {
                totalMarks += marks;
            }

            double percentage = (double)totalMarks / 5;

            // Display total marks, percentage, and result
            Console.WriteLine("\nResult Summary:");
            Console.WriteLine($"Total Marks Obtained: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage:F2}%");

            // Check if the student passed or failed
            if (percentage >= 35)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }

            */
            //Question 15
            //switch.
            /*
            Console.WriteLine("Enter your choice (a-g): ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "a":
                    Console.WriteLine("Sunday");
                    break;
                case "b":
                    Console.WriteLine("Monday");
                    break;
                case "c":
                    Console.WriteLine("Tuesday");
                    break;
                case "d":
                    Console.WriteLine("Wednesday");
                    break;
                case "e":
                    Console.WriteLine("Thursday");
                    break;
                case "f":
                    Console.WriteLine("Friday");
                    break;
                case "g":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            */
            //nested switch.
            /*
            int x = 10, y = 5;
            switch (x)
            {
                case 10:
                    Console.WriteLine("X Value: 10");
                    switch (y)
                    {
                        case 5:
                            Console.WriteLine("Nested Switch Value: 5");
                            switch (y - 2)
                            {
                                case 3:
                                    Console.WriteLine("Another Nested Switch Value: 3");
                                    break;
                            }
                            break;
                    }
                    break;
                case 15:
                    Console.WriteLine("X Value: 15");
                    break;
                case 20:
                    Console.WriteLine("X Value: 20");
                    break;
                default:
                    Console.WriteLine("Not Known");
                    break;
            }
            */

            //Question 16.
            /*

            Console.WriteLine("---------Using Break---------");

            // Using Break
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Breaking the loop at i = 3");
                    break;
                }

                Console.WriteLine($"Iteration {i}");
            }

            Console.WriteLine("----Using Continue-----");

            // Using Continue
            for (int j = 1; j <= 5; j++)
            {
                if (j == 2 || j == 4)
                {
                    Console.WriteLine($"Skipping iteration {j} using Continue");
                    continue;
                }

                Console.WriteLine($"Iteration {j}");
            }
            */
            //Question17
            /*
            Console.WriteLine("Printing numbers from 1 to 100 (skipping 25, 40, and 90):");

            for (int i = 1; i <= 100; i++)
            {
                if (i == 25 || i == 40 || i == 90)
                {
                    // Skip printing for specific numbers
                    continue;
                }

                Console.Write(i + " ");
            }
            */
            //Question18
            /*
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] numbers = new int[n];

                // Read numbers from the user
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out numbers[i]))
                    {
                        // Check if the number is divisible by 2 and 3
                        if (numbers[i] % 2 == 0 && numbers[i] % 3 == 0)
                        {
                            Console.WriteLine($"{numbers[i]} is divisible by 2 and 3.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("2 Please enter a valid integer.");
                        // Decrement i to re-enter the current number
                        i--;
                    }
                }
            }
            else
            {
                Console.WriteLine(" Please enter a valid positive integer.");
            }
            */

            //Question 19
            /*
            // Define a string array of size 10
            string[] studentNames = new string[10];

            // Insert names of 10 students
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                studentNames[i] = Console.ReadLine();
            }

            // List the names of students that end with the letter 'a'
            Console.WriteLine("\nStudents whose names end with 'a':");
            foreach (string name in studentNames)
            {
                if (name.EndsWith("a", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(name);
                }
            }
            */

            //Question 20
            /*
            Console.WriteLine("-----Concatenation------");
            string fname = "Naresh";
            string lname = " Khatri";
            string fullname = string.Concat(fname, lname);
            Console.WriteLine("1. Concatenation: " + fullname);

            Console.WriteLine("------Substring--------");
            string originalString = "Programming";
            string substring = originalString.Substring(0, 4);
            Console.WriteLine("2. Substring: " + substring);

            Console.WriteLine("-----Length------");
            string name = "Naresh";
            int length = name.Length;
            Console.WriteLine("3. Length: " + length);

            Console.WriteLine("-----ToUpper and ToLower----");
            string Fullname = "Naresh Khatri";
            string upperCasename = Fullname.ToUpper();
            string lowerCasename = Fullname.ToLower();
            Console.WriteLine("4. ToUpper: " + upperCasename);
            Console.WriteLine("   ToLower: " + lowerCasename);

            Console.WriteLine("----------IndexOf----------");
            string indexOfString = "Bisham Thapa";
            int index = indexOfString.IndexOf("Thapa");
            Console.WriteLine("5. IndexOf 'Thapa': " + index);

            Console.WriteLine("-----Replace-------");
            string replaceString = "replace this";
            string replacedString = replaceString.Replace("this", "that");
            Console.WriteLine("6. Replace: " + replacedString);
            */

            //question 21
            string[] birdNames = { "Sparrow", "Robin", "Eagle", "Swan", "Parrot" };
          
            // Print names of birds starting with 's'
            Console.WriteLine("Birds whose names start with 's':");
            foreach (string birdName in birdNames)
            {
          
                if (birdName.StartsWith("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(birdName);
                }
                
            }
            Console.ReadKey();

        }
    }
}


