using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            #region "Hello World"
            Console.WriteLine("Hello World!");
            #endregion

            #region "MinMax"
            MinMax.MinOfTwo minOfTwo = new MinMax.MinOfTwo();
            MinMax.MaxOfTwo maxOfTwo = new MinMax.MaxOfTwo();
            Console.WriteLine("Enter the two numbers : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter Integers only");
                throw;
            }
            minOfTwo.a = a;
            minOfTwo.b = b;
            maxOfTwo.a = a;
            maxOfTwo.b = b;
            int Min = minOfTwo.getMin();
            int Max = maxOfTwo.getMax();

            Console.WriteLine("Minimum of two numbers : "+Min);
            Console.WriteLine("Maximum of two numbers : "+Max);
            #endregion

            #region "Ternary Max"
            TernaryMax.TernaryMax ternaryMax = new TernaryMax.TernaryMax();
            Console.WriteLine("Enter two numbers for Ternary Max now : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter Integers only");
                throw;
            }
            ternaryMax.a = a;
            ternaryMax.b = b;
            int max=ternaryMax.getMax();
            Console.WriteLine("The maximum of two numbers is : "+max);
            #endregion

            #region "Swapping"
            Swap.Swap swap = new Swap.Swap();
            Console.WriteLine("Enter two numbers for Swapping : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter Integers only");
                throw;
            }
            Console.WriteLine("Before Swapping : a = "+a+" and b = "+b);
            swap.a = a;
            swap.b = b;
            swap.SwapInt();
            a = swap.a;
            b = swap.b;
            Console.WriteLine("After Swapping : a = "+a+" and b = "+b);
            #endregion

            #region "Array Max"
            ArrayMax.ArrayMax arrayMax = new ArrayMax.ArrayMax();
            Console.WriteLine("Enter the length of Array");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] c = new int[l];
            try
            {
                for(int i=0;i<l;i++){
                    c[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Enter integers only");
                throw;
            }
            arrayMax.a=c;
            Console.WriteLine("Maximum value in array = "+arrayMax.maxArray());
            #endregion
        }
    }
}
