/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode MiddleNode(ListNode head) 
    {
        var count = 0;
        var ptr = head;
        while(ptr != null)
        {
            count++;
            ptr = ptr.next;
        }
        var mid = count / 2 + 1; 
        //Console.WriteLine(count);
        //Console.WriteLine(mid);
        ptr = head;
        for(int i = 1; i <= mid-1; i++)
        {
            //Console.WriteLine(ptr.val);
            ptr = ptr.next;
        }
        
        return ptr;
    }
}