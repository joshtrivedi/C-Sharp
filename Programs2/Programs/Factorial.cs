using System;
namespace Programs2.Factorial
{
    public class Factorial
    {
        public int checkFact(int n)
        {
            if (n==1)
            return 1;
            else 
            return n * checkFact(n-1);
        }
    }
}