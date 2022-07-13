# Reverse String
## Problem Statement

Write a function that reverses a string. The input string is given as an array of characters  `s`.

You must do this by modifying the input array  [in-place](https://en.wikipedia.org/wiki/In-place_algorithm)  with  `O(1)`  extra memory.

**Example 1:**
```
Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]
```

**Example 2:**
```
Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]
```

**Constraints:**

-    `1 <= s.length <= 10^5`
-   `s[i]`  is a  [printable ascii character](https://en.wikipedia.org/wiki/ASCII#Printable_characters).

## Approach & Answer

1. Initialize `beg` at 0 and `end` at last position of array.
2. Loop till `beg < end`.
3. Swap `s[beg]` and `s[end]`.