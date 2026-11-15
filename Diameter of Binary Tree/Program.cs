/*
 Given the root of a binary tree, return the length of the diameter of the tree.

The diameter of a binary tree is the length of the longest path between any two nodes in a tree. 
This path may or may not pass through the root.

The length of a path between two nodes is represented by the number of edges between them.

Example 1:
Input: root = [1,2,3,4,5]
Output: 3
Explanation: 3 is the length of the path [4,2,1,3] or [5,2,1,3].
Example 2:

Input: root = [1,2]
Output: 1
 
 */


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {

        DFS(root);
        return diameter;
    }

    private int DFS(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = DFS(node.left);
        int right = DFS(node.right);

        diameter = Math.Max(diameter, left + right);

        return 1 + Math.Max(left, right);
    }
}