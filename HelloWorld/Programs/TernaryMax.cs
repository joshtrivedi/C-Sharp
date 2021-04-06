using System;

namespace HelloWorld.TernaryMax
{
    public class TernaryMax
    {
        public int a;
        public int b;

        public int getMax(){
            int max;
            max = (a>b)?a:b;
            return max;
        }
    }
}
