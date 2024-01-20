using System;


namespace lab1
{ class Shape
    {
        private int length;
        private int breadth;
        private int height;

        public Shape()
        {
            length = 0;
            breadth = 0;
            height = 0;
        }

        public Shape( int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public  Shape(int lenght, int breadth, int height)
        {
            this.length = lenght;
            this.breadth = breadth;
            this.height = height;
        }
      public void  calcAreaReactangel()
        {
            int area = length * breadth;
            Console.WriteLine("Area is :" +area);
        }
       public void calcVolumeBox()
        {
            int volume = length * breadth * height;
            Console.WriteLine("Volune is : " +volume );
        }

    }
}
