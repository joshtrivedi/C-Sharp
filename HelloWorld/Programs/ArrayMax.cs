using System;

namespace HelloWorld.ArrayMax
{
    public class ArrayMax
    {
        public int[] a;
        
        public int maxArray(){
            int Max=a[0];
            for(int i = 0; i<a.Length;i++){
                if(Max<a[i]) Max=a[i];
            }
            return Max;
        }
    }
}