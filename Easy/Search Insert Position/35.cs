public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int beg = 0;
        int end = nums.Length - 1;
        int mid = 0;
        
        while(beg <= end)
        {
            Console.WriteLine(beg);
            Console.WriteLine(end);
            
            mid = (beg + end) / 2;
            
            Console.WriteLine(beg);
            Console.WriteLine(mid);
            Console.WriteLine(end);
            
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] > target)
            {
                end = mid - 1;
                Console.WriteLine("here");
            }
            else
            {
                beg = mid + 1;
                Console.WriteLine("here1");
            }
            
            Console.WriteLine(beg);
            Console.WriteLine(end);
            
        }
        
        if(nums[mid] < target)
        {
            return mid + 1;
        }
        return mid;
    }
}