using System;

namespace Programs2.MinMax
{
    public class MinMax
    {
        public int[] arr;
        
        public int maxArray(){
            int Max=arr[0];
            for(int i = 0; i<arr.Length;i++){
                if(Max<arr[i]) Max=arr[i];
            }
            return Max;
        }
        public int minArray(){
            int Min=arr[0];
            for(int i=0;i<arr.Length;i++){
                if(Min>arr[i]) Min=arr[i];
            }
            return Min;
        }
    }
}