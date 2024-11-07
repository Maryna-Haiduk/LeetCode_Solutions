using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _501_FindModeBST
    {
        public int[] FindMode(TreeNode root)
        {
            var modes = new List<int>();


            var result = modes.ToArray();
            return result;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right=null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

    }
}
