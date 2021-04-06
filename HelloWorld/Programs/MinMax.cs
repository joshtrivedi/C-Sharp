using System;

namespace HelloWorld.MinMax
{
    public class MinOfTwo {
        public int a;
        public int b;

        public int getMin()
        {
            return Math.Min(a,b);
        }
    }

    public class MaxOfTwo {
        public int a;
        public int b;
        
        public int getMax(){
            return Math.Max(a,b);
        }
    }
}