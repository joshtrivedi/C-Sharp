using System;

namespace HelloWorld.Swap
{
    public class Swap
    {
        public int a;
        public int b;

        public void SwapInt()
        {
            a = a*b;
            b=a/b;
            a=a/b;
        }
    }
}