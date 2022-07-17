# Reverse String
## Problem Statement


Given the  `head`  of a singly linked list, return  _the middle node of the linked list_.

If there are two middle nodes, return  **the second middle**  node.

**Example 1:**
```
Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
```

**Example 2:**
```
Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
```

**Constraints:**
-   The number of nodes in the list is in the range  `[1, 100]`.
-   `1 <= Node.val <= 100`

## Approach & Answer
### Solution 1
1. Run a loop to count the number of nodes in the linked list. Store it in `count`.
2. Create `mid = count / 2 + 1`
3. Run loop till mid and traverse linked list.
4. Return the pointer;

**Time Complexity:** O(n) used 2 loops
**Space Complexity:** O(1) for mid, count, ptr and i for iteration


### Solution 2
1. Create 2 pointers `slowPtr` and `fastPtr`
2. Traverse the link list in such a way till `fastPtr != null && fastPtr?.next != null`
3. In the loop body `slowPtr = slowPtr.next` and `fastPtr = fastPtr.next.next`
4. Return `slowPtr`

**Time Complexity:** O(n) used single loop
**Space Complexity:** O(1) for slowPtr and fastPtr
