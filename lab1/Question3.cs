using System;
namespace lab1
{ 
    internal class Question3
    {
            private int length;
            private int breadth;
            private int height;

            public void SetBoxes(int lenght, int breadth, int height)
            {
                this.length = lenght;
                this.breadth = breadth;
                this.height = height;
            }
            // method that calcualte volume
            public void CalcVol()
            {
                Console.WriteLine("The volume  is " + (length * breadth * height));
            }
            //overloading
            public static Question3 operator +(Question3 b1, Question3 b2)
            {
                Question3 b3 = new Question3();
                b3.length = b1.length + b2.length;
                b3.breadth = b1.breadth + b2.breadth;
                b3.height = b1.height + b2.height;
                return b3; // return type is class, so object should be return
            }

            // overloading  "==" operator (compreison operator)
            public static bool operator ==(Question3 b1, Question3 b2)
            {
                bool temp = false;
                if (b1.length == b2.length && b1.breadth == b2.breadth && b1.height == b2.height)
                {

                    temp = true;
                    return true;

                }
                else
                {
                    return temp;
                }
            }
            public static bool operator !=(Question3 b1, Question3 b2)
            {
                bool temp = false;
                if (b1.length != b2.length && b1.breadth != b2.breadth && b1.height != b2.height)
                {

                    temp = true;
                    return true;

                }

                else
                {
                    return temp;
                }
            }
        }
    }
