# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reverseKGroup(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        dummy = ListNode(0, head)
        group_prev = dummy

        while True:
            kth = self.getKth(group_prev, k)
            if not kth:
                break
            group_next = kth.next

            prev, curr = kth.next, group_prev.next
            while curr != group_next:
                t = curr.next
                curr.next = prev
                prev = curr
                curr = t
            
            tmp = group_prev.next
            group_prev.next = kth
            group_prev = tmp
        
        return dummy.next



    def getKth(self, curr, k):
        while k > 0 and curr:
            k -= 1
            curr = curr.next
        return curr

                



        

