using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class _700_Search_In_BST
    {
        /*
         * 700. Search in a Binary Search Tree
                You are given the root of a binary search tree (BST) and an integer val.

                Find the node in the BST that the node's value equals val 
                and return the subtree rooted with that node. If such a node does not exist, return null.
         */

        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val)
                return root;

            if (val < root.val)
                return SearchBST(root.left, val);

            else
                return SearchBST(root.right, val);
        }

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
    }
}

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
