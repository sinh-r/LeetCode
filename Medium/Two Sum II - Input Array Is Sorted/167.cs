public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int beg = 0;
        int end = numbers.Length - 1;
        while(beg <= end)
        {
            if(numbers[beg] + numbers[end] == target)
            {
                return new int[] {beg + 1, end + 1};
            }
            else if(numbers[beg] + numbers[end] > target)
            {
                end--;
            }
            else
            {
                beg ++;
            }
        }
        return new int[] {beg + 1, end + 1};
    }
}