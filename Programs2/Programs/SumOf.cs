using System;

namespace Programs2.SumOf
{
    public class SumOf
    {
        public int[] arr = new int[10];

        public void func()
        {
            double sum=0.00;
            for(int i=0;i<10;i++)
            {
                sum += arr[i];
            }
            double avg = sum/10;
            var s = string.Format("{0:0.00}",avg);
            Console.WriteLine("Sum of all numbers = "+sum);
            Console.WriteLine("Average of all numbers = "+s);
        }
    } 
}