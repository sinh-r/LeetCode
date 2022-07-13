public class Solution
{
    public bool IsHillValley(int left, int target, int right)
    {
        return ((left > target && right > target) || (left < target && right < target)) ? true : false;
    }
    
    public int CountHillValley(int[] nums) 
    {
        var count = 0;
        int i = 1;
        while(i < nums.Length - 1)
        {
            Console.WriteLine(i);
            if(IsHillValley(nums[i-1], nums[i], nums[i+1]))
            {
                count++;
                i++;
            }
            else if(nums[i-1] == nums[i])
            {
                while(nums[i-1] == nums[i])
                {
                    i++;
                }
                if(IsHillValley(nums[i-1], nums[i], nums[i+1]))
                {
                    count++;
                    i++;
                }
            }
            else
            {
                var left = nums[i-1];
                while(nums[i+1] == nums[i])
                {
                    i++;
                }
                if(IsHillValley(left, nums[i], nums[i+1]))
                {
                    count++;
                    i++;
                }
            }
        }
        
        return count;
    }
}

public class Program
{
    public static void Main()
    {
        int nums = new int[6]{2, 4, 1, 1, 6, 5};
        var sol = new Solution();
        var ans = sol.CountHillValley(nums);
        Console.WriteLine(ans);
    }
}