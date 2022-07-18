# Search Insert Position
## Problem Statement
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with `O(log n)`  runtime complexity.
**Example 1:**
```
Input: nums = [1,3,5,6], target = 5
Output: 2
```

**Example 2:**
```
Input: nums = [1,3,5,6], target = 2
Output: 1
```
**Example 3:**
```
Input: nums = [1,3,5,6], target = 7
Output: 4
```

**Constraints:**
-   `1 <= nums.length <= 10^4`
-   `-104  <= nums[i] <= 10^4`
-   `nums`  contains  **distinct**  values sorted in  **ascending**  order.
-   `-10^4  <= target <= 10^4`

## Approach & Answer
Declare and initialize

-   beg = 0
-   end = length(nums) - 1
-   mid
1.  Find mid term.  `mid = (beg + end) / 2`.
2.  If mid term is target return the position,
3.  If mid term is greater than target, i.e. the number is in left half of the array. So decrease end pointer to mid - 1.  `end = mid - 1`.
4.  If mid term is lower than target i.e. the number is in right half of the array. So increase the beg pointer to mid + 1.  `beg = mid + 1`.
5.  Repeat Step 1 to 4 till  `beg <= end`.
6. If mid term is less than target then `return mid+1`. Else `return mid`.