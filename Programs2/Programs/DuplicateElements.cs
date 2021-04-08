using System;
namespace Programs2.DuplicateElements
{
    public class DuplicateElements
    {
        public int[] arr;
        public int dupliElements()
        {
            int count=0;
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        //Console.WriteLine("Duplicate elements found for : "+arr[j]);
                        count++;
                    }
                }
            }
            return count;
        }
    }
}