public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int beg = 0;
        int end = s.Length - 1;
        while(beg < end)
        {
            var temp = s[beg];
            s[beg] = s[end];
            s[end] = temp;
            
            beg++;
            end--;
        }
    }
}