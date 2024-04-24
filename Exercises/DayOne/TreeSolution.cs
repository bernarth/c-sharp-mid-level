namespace DayOne;

public static class TreeSolution
{
    public static int MaxSum(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        if (root.left == null && root.right == null)
        {
            return root.value;
        }

        var leftMax = root.left != null ? MaxSum(root.left) : int.MinValue;
        var rigthMax = root.right != null ? MaxSum(root.right) : int.MinValue;

        return root.value + Math.Max(leftMax, rigthMax);
    }
}