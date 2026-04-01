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
    public ListNode MergeKLists(ListNode[] lists) {
        var dummy = new ListNode();
        var cur = dummy;

        if (lists.Length == 0) return null;

        while (true)
        {
            var j = 0;
            ListNode lower = null;
            
            for (var i = 0; i < lists.Length; i++)
            {
                var node = lists[i];
                if (node != null && (lower == null || node.val < lower.val))
                {
                    lower = node;
                    j = i;
                }
            }

            if (lower == null) break;

            cur.next = lower;
            cur = cur.next;

            lists[j] = lists[j].next;
        }

        return dummy.next;
    }
}
