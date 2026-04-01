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

public class Solution {
    public bool HasCycle(ListNode head) {
        var f = head;

        while(f != null)
        {
            f = f.next;
            if (f == null) return false;

            f = f.next;
            head = head.next;

            if (f == head) return true;
        }

        return false;        
    }
}
