using System;
namespace lab1
{
     class Number
    {
        private int x;
        private int y;

        public Number()
        {
            x = 0;
            y = 0;
        }
        public Number( int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Findodd()
        {
            Console.WriteLine($" the odd nuber between {x} and{y} are:");
            for(int i = x; i<y; i++)
            {
                if( i%2 !=0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine();
        }

        public void FindEven()
        {
            Console.WriteLine($"the even number between {x} and {y} are:");
            for( int i =x; i<y; i++)
            {
                if( i%2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine();
        }
    }
}
