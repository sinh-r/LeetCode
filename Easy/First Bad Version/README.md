# First Bad Version
## Problem Statement

You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have  `n`  versions  `[1, 2, ..., n]`  and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API  `bool isBadVersion(version)`  which returns whether  `version`  is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.
**Example 1:**
```
Input: n = 5, bad = 4
Output: 4
Explanation:
call isBadVersion(3) -> false
call isBadVersion(5) -> true
call isBadVersion(4) -> true
Then 4 is the first bad version.
```

**Example 2:**
```
Input: n = 1, bad = 1
Output: 1
```

**Constraints:**
-   `1 <= bad <= n <= 2^31  - 1`

## Approach & Answer
We already have method called as `IsBadVersion(int)`.

Declare and initialize

-   beg = 0
-   end = length(nums) - 1
-   mid

1.  Find mid term.  `mid = (beg + end) / 2`.
2.  If `IsBadVersion(int)` is **true** then decrease end pointer to mid - 1.  `end = mid - 1`.
3.   If `IsBadVersion(int)` is **false** then increase the beg pointer to mid + 1.  `beg = mid + 1`.
4.  Repeat Step 1 to 4 till  `beg <= end`.
5.  If `IsBadVersion(int)` is **true** then `return mid`.
6. If `IsBadVersion(int)` is **false** then `return mid + 1`.
