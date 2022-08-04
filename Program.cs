using System;

namespace MinAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 Min number of array
            //Console.WriteLine(Min(3, 22, 23, 4, 4, 1, 1, 3, 34, 342, 42, 34, 564, 54, 654, 5, 0));
            #endregion
            #region Task2 Areas
            Console.WriteLine("Enter the radius of circle : ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lenght of  rectangular:");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the wide of rectangular :");
            int  wide= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lenght of parallelepiped :");
            int lenghtPar= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the wide of  parallelepiped:");
            int widePar = int.Parse(Console.ReadLine());
            Console.WriteLine("Height of parallelepiped: ");
            int heightPar = int.Parse(Console.ReadLine());
            Console.WriteLine("One side of Triangle:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second side of Triangle:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Third side of Triangle:");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine("Overload1:");
            Console.WriteLine(Area(radius));

            Console.WriteLine("Overload2:");
            Console.WriteLine(Area(lenght,wide));

            Console.WriteLine("Overload3:");
            Console.WriteLine(Area(lenghtPar,widePar,heightPar));

            Console.WriteLine("Overload4:");
            Console.WriteLine(Area(radius,a,b,c));



            #endregion

        }
        #region Task1 Min number of array
        //static int Min(params int[] arr)
        //{
        //    int min = 0;
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[min] > arr[i])
        //        {
        //            min = i;
        //        }
        //    }
        //    return arr[min];
        //}
        #endregion
        #region Task2 Areas
        static int Area(int radius)
        {
            return radius * radius * 3;
        }
        static int Area(int a, int b)
        {
            return a * b;
        }
        static int Area(int a, int b, int c)
        {
            return 2 * (a * b + b * c + a * c);
        }
        static int Area(int radius, int a, int b, int c) 
        {
           int p = (a + b + c) / 2;
            return p * radius;     
        }
        
            
        
        #endregion
    }

}
