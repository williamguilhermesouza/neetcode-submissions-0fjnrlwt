# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        carry = 0
        dummy = ListNode()
        cur = dummy

        while l1 and l2:
            node = ListNode()
            s = l1.val + l2.val + carry
            carry = 0
            
            if s > 9:
                carry = s // 10
                s = s % 10
            
            node.val = s
            cur.next = node
            cur = cur.next

            l1 = l1.next
            l2 = l2.next

        while l1:
            node = ListNode()
            s = l1.val + carry
            carry = 0

            if s > 9:
                carry = s // 10
                s = s % 10
                
            node.val = s
            cur.next = node
            cur = cur.next

            l1 = l1.next
                

        while l2:
            node = ListNode()
            s = l2.val + carry
            carry = 0

            if s > 9:
                carry = s // 10
                s = s % 10
                
            node.val = s
            cur.next = node
            cur = cur.next

            l2 = l2.next
        
        if carry > 0:
            node = ListNode()
            node.val = carry
            cur.next = node
            cur = cur.next
                
        return dummy.next