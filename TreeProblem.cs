using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
    }
    internal class TreeProblem
    {
        //Binary Tree From Inorder And Preorder
        List<int> preorder, inorder;
        public TreeNode buildTree(List<int> A, List<int> B)
        {
            if (A == null || B == null || A.Count == 0 || B.Count != A.Count)
                return null;
            preorder = A;
            inorder = B;
            return rec(0, preorder.Count - 1, 0);
        }
        private TreeNode rec(int start, int end, int preIndex)
        {
            if (start > end)
                return null;
            //Process Root Node
            TreeNode root = new TreeNode(preorder[preIndex]);
            int i = start;
            //Find the ith value in inorder
            for (; i <= end; i++)
            {
                if (inorder[i] == root.val)
                    break;
            }
            //repeat same process again on left and right node
            root.left = rec(start, i - 1, preIndex + 1);
            root.right = rec(i + 1, end, preIndex + i - start + 1);
            return root;
        }
    }
  
}
