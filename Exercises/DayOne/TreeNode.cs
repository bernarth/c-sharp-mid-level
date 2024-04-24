namespace DayOne;

using System.Collections.Generic;

public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int value;

    public TreeNode(int value, TreeNode left = null, TreeNode right = null)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
}