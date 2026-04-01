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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode head = list1.val <= list2.val ? list1 : list2;
        ListNode curr = head;

        ListNode p1 = list1.val <= list2.val ? list1.next : list1;
        ListNode p2 = list1.val <= list2.val ? list2 : list2.next;

        while(p1 != null && p2 != null)
        {
            if (p2.val < p1.val)
            {
                curr.next = p2;
                p2 = p2.next;
                curr = curr.next;
            }
            else
            {
                curr.next = p1;
                p1 = p1.next;
                curr = curr.next;
            }
        }

        while (p1 != null)
        {
            curr.next = p1;
            p1 = p1.next;
            curr = curr.next;
        }

        while (p2 != null)
        {
            curr.next = p2;
            p2 = p2.next;
            curr = curr.next;
        }

        return head;
    }
}