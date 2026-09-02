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
        if (list1 == null)
        {
            return list2;
        }
        if (list2 == null)
        {
            return list1;
        }
        ListNode head = new ListNode();
        ListNode currentNode = head;

        while (list1 != null && list2 != null)
        {
            //Compare the lower value
            if (list1.val <= list2.val)
            {
                //if first list value is lower then point to the memory 
                //that list1 memory
                currentNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2.next;
            }

            currentNode = currentNode.next;
        }

        //if one list is before the other
        //this is to solve issue
        if (list1 != null)
        {
            currentNode.next = list1;
        }
        else
        {
            currentNode.next = list2;
        }
        //skips the returns the real list
        return head.next;
    }
}