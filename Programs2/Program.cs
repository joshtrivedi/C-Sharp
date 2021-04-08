using System;

namespace Programs2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region "ReverseStr"
            Console.WriteLine("Enter a string");
            ReverseStr.ReverseStr reverseStr = new ReverseStr.ReverseStr();
            reverseStr.str = Console.ReadLine();
            string strRev = reverseStr.reversal();
            Console.WriteLine("The reversed string = " + strRev);
            #endregion

            #region "SumOf"
            Console.WriteLine("Enter 10 numbers");
            SumOf.SumOf sumOf = new SumOf.SumOf();
            int[] arr = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    sumOf.arr[i] = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter integers only.");
                throw;
            }
            sumOf.func();
            #endregion

            #region "MinMax"
            MinMax.MinMax minMax = new MinMax.MinMax();
            Console.WriteLine("Enter length of array");
            int l;
            l=Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[l];
            try
            {
                Console.WriteLine("Enter the "+l+" Elements of Array: ");
                for(int i=0;i<l;i++)
                {
                    arr1[i]=Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter integer only.");
                throw;
            }
            minMax.arr = arr1;
            Console.WriteLine("Minumum element of the array : "+minMax.minArray());
            Console.WriteLine("Maximum element of the array : "+minMax.maxArray());
            
            #endregion
            
            #region "Duplicate Elements"
            DuplicateElements.DuplicateElements duplicateElements = new DuplicateElements.DuplicateElements();
            Console.WriteLine("Enter length of array");
            int l1;
            l1=Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[l1];
            try
            {
                Console.WriteLine("Enter the "+l1+" Elements of Array: ");
                for(int i=0;i<l1;i++)
                {
                    arr2[i]=Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter integer only.");
                throw;
            }
            duplicateElements.arr = arr2;
            int count = duplicateElements.dupliElements();
            Console.WriteLine("Total number of duplicate elements : "+count);
            #endregion
            
            int value;
            int ret;
            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Enter integers only.");
                throw;
            }
            Factorial.Factorial factorial = new Factorial.Factorial();
            ret = factorial.checkFact(value);
            Console.WriteLine("Factorial of {0} is : {1}",value, ret);
            Console.ReadLine();
        }
    }
}
