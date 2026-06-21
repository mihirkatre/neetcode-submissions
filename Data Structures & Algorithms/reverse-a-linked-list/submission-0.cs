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
    public ListNode ReverseList(ListNode head) {
        //current node to process
        ListNode curr = head;
        //the next node to come after reversed
        ListNode prev = null;

        while(curr != null){
            //store next node so that you do not break the chain
            ListNode temp = curr.next;
            //make the next to previous
            curr.next = prev;
            //make previous as current
            prev = curr;
            //make current as next
            curr = temp;
        }
        //in the end, the head will be prev
        return prev;
    }
}
