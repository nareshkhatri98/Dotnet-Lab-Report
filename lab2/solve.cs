using System;
namespace lab2
{
    interface Num
    {
        int  add(int x, int y);
        int diff(int x, int y);
    }
     class solve: Num 
    {
        public int add( int x, int y)
        {
            return x + y;

        }
        public int diff(int x, int y) 
        {
            return x - y;
        }
    }
}
