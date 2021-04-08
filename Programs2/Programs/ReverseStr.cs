using System;

namespace Programs2.ReverseStr
{
    public class ReverseStr
    {
        public string str;

        public string reversal()
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i=0,j=str.Length-1;i<str.Length;i++,j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }
    }
}