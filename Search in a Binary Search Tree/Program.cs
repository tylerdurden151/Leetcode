/*
 You are given the root of a binary search tree (BST) and an integer val.

Find the node in the BST that the node's value equals val and return the subtree rooted with that node. 
If such a node does not exist, return null.
Input: root = [4,2,7,1,3], val = 2
Output: [2,1,3]

Input: root = [4,2,7,1,3], val = 5
Output: []
 */

// Build the BST from the example: [4,2,7,1,3]
//       4
//      / \
//     2   7
//    / \
//   1   3
TreeNode root = new TreeNode(4,
    new TreeNode(2,
        new TreeNode(1),
        new TreeNode(3)
    ),
    new TreeNode(7)
);

var solution = new Solution();

// Test case 1: val = 2
// Expected output: [2,1,3] (subtree rooted at node with value 2)
TreeNode result1 = solution.SearchBST(root, 2);
Console.WriteLine($"SearchBST(root, 2): {result1?.val} (Expected: 2)");


// Test case 2: val = 5
// Expected output: null (node does not exist)
TreeNode result2 = solution.SearchBST(root, 5);
Console.WriteLine($"SearchBST(root, 5): {result2} (Expected: null)");

//This is provided as a helper class for the binary tree node structure.
//Don't modify it.
//Dont worry making it
public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }


//This is the solution class that contains the method to search for a value in the BST.

public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null || root.val == val)
        {
            return root;
        }
        if (val < root.val)
        {
            return SearchBST(root.left, val);
        }
        else
        {
            return SearchBST(root.right, val);
        }
    }
}