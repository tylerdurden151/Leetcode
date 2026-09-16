/* Given the head of a singly linked list, reverse the list, and return the reversed list.

Example 1:
 * Input: head = [1,2,3,4,5]

Output: [5,4,3,2,1
 */

Solution solution = new Solution();

// Create a linked list using the custom ListNode class
ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);

// Print original list
Console.Write("Original Linked List: ");
PrintList(head);

// Reverse the list
ListNode reversedHead = solution.ReverseList(head);

// Print reversed list
Console.Write("Reversed Linked List: ");
PrintList(reversedHead);

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
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode ReverseList(ListNode? head)
    {
        ListNode? previous = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? nextNode = current.next;

            current.next = previous;

            previous = current;
            current = nextNode;
        }

        return previous ?? new ListNode(0);
    }
}