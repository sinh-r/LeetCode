# Binary Search
## Problem Statement
Given an array of integers  `nums`  which is sorted in ascending order, and an integer  `target`, write a function to search  `target`  in  `nums`. If  `target`  exists, then return its index. Otherwise, return  `-1`.

You must write an algorithm with  `O(log n)`  runtime complexity.

**Example 1:**
```
Input: nums = [-1,0,3,5,9,12], target = 9
Output:  -1
Explanation: 9 exists in nums and its index is 4.`
```

**Example 2:**
```
Input: nums = [-1,0,3,5,9,12], target = 2
Output: 3
Explanation: 2 does not exist in nums so return -1.
```

**Constraints:**

-    `1 <= nums.length <= 104`
-   `-104  < nums[i], target < 104`
-   All the integers in  `nums`  are  **unique**.
-   `nums`  is sorted in ascending order.

## Approach & Answer
For this search to work you have to ensure that the array is **sorted**.
Declare and initialize
- beg = 0
- end = length(nums) - 1
- mid
1. Find mid term. `mid = (beg + end) / 2`
2. If mid term is target return the position
3. If mid term is greater than target, i.e. the number is in left half of the array. So decrease end pointer to mid - 1. `end = mid - 1`
4. If mid term is lower than target i.e. the number is in right half of the array. So increase the beg pointer to mid + 1. `beg = mid + 1`
5. Repeat Step 1 to 4 till `beg <= end` 
