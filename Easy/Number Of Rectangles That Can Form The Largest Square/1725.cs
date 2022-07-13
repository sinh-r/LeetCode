public class Solution 
{
    public int CountGoodRectangles(int[][] rectangles) 
    {
        var freq = new Dictionary<int, int>();
        var maxLen  = 0;
        
        foreach(var rectangle in rectangles)
        {
            var smallestSize = Math.Min(rectangle[0], rectangle[1]);
            maxLen = Math.Max(smallestSize, maxLen );
            if(!freq.ContainsKey(smallestSize))
            {
                freq[smallestSize] = 0;
            }
            freq[smallestSize] ++;
        }
        
        return freq[maxLen];
    }
}