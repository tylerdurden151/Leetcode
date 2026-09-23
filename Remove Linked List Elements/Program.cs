/*
 Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.

 

Example 1:


Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]
Example 2:

Input: head = [], val = 1
Output: []
Example 3:

Input: head = [7,7,7,7], val = 7
Output: []
 
 
 
 */

Solution solution = new Solution();

// Create a linked list using the custom ListNode class
ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(6);
head.next.next.next = new ListNode(3);
head.next.next.next.next = new ListNode(4);
head.next.next.next.next.next = new ListNode(5);
head.next.next.next.next.next.next = new ListNode(6);

Console.Write("Original Linked List: ");
PrintList(head);

ListNode newHead = solution.RemoveElements(head, 6);


Console.Write("Linked List after removing elements: ");
PrintList(newHead);

// Helper method to print the linked list
static void PrintList(ListNode? node)
{
    List<int> values = new List<int>();
    while (node != null)
    {
        values.Add(node.val);
        node = node.next;
    }
    Console.WriteLine(string.Join(", ", values));
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode();
        ListNode currentNew = dummy;
        ListNode current = head;
        while (current != null)
        {
            if (current.val != val)
            {
                currentNew.next = new ListNode(current.val);
                currentNew = currentNew.next;
            }
            current = current.next;
        }

        return dummy.next;
    }
}