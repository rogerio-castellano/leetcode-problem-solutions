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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode result = null;
        ListNode lastItem = null;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                if (result == null)
                {
                    result = list1;
                    lastItem = list1;
                }
                else
                {
                    lastItem.next = list1;
                    lastItem = lastItem.next;
                }

                list1 = list1.next;
            }
            else
            {
                if (result == null)
                {
                    result = list2;
                    lastItem = list2;
                }
                else
                {
                    lastItem.next = list2;
                    lastItem = lastItem.next;
                }
                list2 = list2.next;
            }
        }

        while (list1 != null)
        {
            if (result == null)
            {
                result = list1;
                lastItem = list1;
            }
            else
            {
                lastItem.next = list1;
                lastItem = lastItem.next;
            }

            list1 = list1.next;
        }

        while (list2 != null)
        {
            if (result == null)
            {
                result = list2;
                lastItem = list2;
            }
            else
            {
                lastItem.next = list2;
                lastItem = lastItem.next;
            }
            list2 = list2.next;
        }

        return result;
    }
}