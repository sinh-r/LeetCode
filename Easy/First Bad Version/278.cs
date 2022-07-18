/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        int beg = 1;
        int end = n;
        int mid = 0;
        
        while(beg <= end)
        {
            mid = beg + (end - beg) / 2;
            
            if(IsBadVersion(mid))
            {
                end = mid - 1;
            }
            else
            {
                beg = mid + 1;
            }
        }
        
        if(IsBadVersion(mid))
        {
            return mid;
        }
        
        return mid+1;
            
    }
}