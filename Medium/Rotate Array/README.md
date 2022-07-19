# Rotate Array
## Problem Statement

Given an array, rotate the array to the right by `k` steps, where `k` is non-negative.

**Example 1:**
```
Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
```

**Example 2:**
```
Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation:
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
```

**Constraints:**
-   `1 <= nums.length <= 10^5`
-   `-2^31  <= nums[i] <= 2^31  - 1`
-   `0 <= k <= 10^5`

## Approach & Answer
 Lets assume for array  `[1,2,3,4,5,6,7]` of size `n = 7` we have to rotate to right by `k = 3` times.
What can be done is we divide the array in two parts:
1. 1st part can be from `0` to `n - k -1` here it will be from 0 to 3 `[1,2,3,4]`
2. 2nd part can be from `n - k` to `n - 1` here it will be `[5,6,7]`

Now reverse these two parts and the end result will be : `[4,3,2,1,7,6,5]`

Now reverse this array as a whole: `[5,6,7,1,2,3,4]`. **This is the answer**.

**Time Complexity:** O(n) By using 3 loops and swaping the elements should be able to reverse the array
**Space Complexity:** O(1) extra variable might be needed for swapping and for loop.