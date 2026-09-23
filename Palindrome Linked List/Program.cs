/*
 Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

 

Example 1:


Input: head = [1,2,2,1]
Output: true
Example 2:


Input: head = [1,2]
Output: false
 
 
 */
Solution solution = new Solution();

// Create a linked list using the custom ListNode class
ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(2);
head.next.next.next = new ListNode(1);

Console.WriteLine(solution.IsPalindrome(head)); // Output: true




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
    public bool IsPalindrome(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        // 1. Find the middle
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. Reverse the second half
        ListNode previous = null;

        while (slow != null)
        {
            ListNode nextNode = slow.next;

            slow.next = previous;
            previous = slow;

            slow = nextNode;
        }

        // 3. Compare both halves
        ListNode left = head;
        ListNode right = previous;

        while (right != null)
        {
            if (left.val != right.val)
            {
                return false;
            }

            left = left.next;
            right = right.next;
        }

        return true;
    }
}