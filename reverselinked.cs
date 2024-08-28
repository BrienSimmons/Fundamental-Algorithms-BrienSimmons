public class Solution {
    public ListNode ReverseList(ListNode head) {
        // Base case: if head is null or head is the last node
        if (head == null || head.next == null) {
            return head;
        }
        
        // Recursively reverse the rest of the list
        ListNode reversedList = ReverseList(head.next);
        
        // Reverse the current node's pointer
        head.next.next = head;
        head.next = null;
        
        return reversedList;
    }
}