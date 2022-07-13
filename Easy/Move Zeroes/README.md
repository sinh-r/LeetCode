# Move Zeroes
## Problem Statement

Given an integer array  `nums`, move all  `0`'s to the end of it while maintaining the relative order of the non-zero elements.

**Note**  that you must do this in-place without making a copy of the array.
**Example 1:**
```
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
```

**Example 2:**
```
Input: nums = [0]
Output: [0]
```

**Constraints:**

-    `1 <= nums.length <= 104`
-   `-2^31  <= nums[i] <= 2^31  - 1`

## Approach & Answer
As question mentions an **in-place approach so we cannot create another array**.

1. Maintain a variable `zeroIdx` which will track the position of **1st 0 in the array** .
2. When you find 0 for first time assign its position to `zeroIdx`.
3. From there check if the number is not 0.
4. If it is not a zero swap the element and increment `zeroIdx`.
5. Repeat these steps till the array is traversed.
