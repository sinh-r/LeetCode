public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        var zeroIdx = -1;
        for(int i = 0; i < nums.Length; i++)
        {
            if(zeroIdx == -1)
            {
                if(nums[i] == 0)
                {
                    zeroIdx = i;
                }
            }
            else
            {
                if(nums[i] != 0)
                {
                    var temp = nums[i];
                    nums[i] = nums[zeroIdx];
                    nums[zeroIdx] = temp;
                    zeroIdx++;
                }
            }
        }
    }
}