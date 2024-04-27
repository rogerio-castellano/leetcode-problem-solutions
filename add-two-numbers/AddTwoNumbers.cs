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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var result = new ListNode();
        var currentNode = result;
        var carryOver = 0;
        var firstIteration = true;
        while (l1 != null && l2 != null)
        {
            if (!firstIteration)
            {
                var newNode = new ListNode();
                currentNode.next = newNode;
                currentNode = newNode;
            }

            var sum = l1.val + l2.val + carryOver;
            currentNode.val = sum % 10;
            carryOver = (int)(sum / 10);
            l1 = l1.next;
            l2 = l2.next;
            firstIteration = false;
        }

        var remainingList = l1 != null ? l1 : l2;

        while (remainingList != null)
        {
            var newNode = new ListNode();
            var sum = remainingList.val + carryOver;

            newNode.val = sum % 10;
            carryOver = (int)(sum / 10);

            currentNode.next = newNode;
            currentNode = newNode;
            remainingList = remainingList.next;
        }

        if (carryOver == 1)
        {
            var newNode = new ListNode();
            newNode.val = carryOver;
            currentNode.next = newNode;
        }

        return result;
    }
}