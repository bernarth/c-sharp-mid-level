using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;

        public static bool IsPerfect(TreeNode root)
        {          
            if(root == null || Depth(root.left) == Depth(root.right) && IsPerfect(root.left) && IsPerfect(root.right))
            {
                return true;
            }

            return false; // TODO: implementation
        }

        public static int Depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(Depth(root.left), Depth(root.right));
        }

        public static TreeNode Leaf()
        {
            return new TreeNode();
        }

        public static TreeNode Join(TreeNode left, TreeNode right)
        {
            return new TreeNode().WithChildren(left, right);
        }

        public TreeNode WithLeft(TreeNode left)
        {
            this.left = left;
            return this;
        }

        public TreeNode WithRight(TreeNode right)
        {
            this.right = right;
            return this;
        }

        public TreeNode WithChildren(TreeNode left, TreeNode right)
        {
            this.left = left;
            this.right = right;
            return this;
        }

        public TreeNode WithLeftLeaf()
        {
            return WithLeft(Leaf());
        }

        public TreeNode WithRightLeaf()
        {
            return WithRight(Leaf());
        }

        public TreeNode WithLeaves()
        {
            return WithChildren(Leaf(), Leaf());
        }
    }
}
