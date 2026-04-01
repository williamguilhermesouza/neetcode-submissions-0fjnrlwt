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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0, head);
        var f = dummy;
        var s = dummy;

        for(var i = 0; i <= n; i++)
            f = f.next;
        
        while(f != null)
        {
            f = f.next;
            s = s.next;
        }

        s.next = s.next.next;

        return dummy.next;
    }
}
