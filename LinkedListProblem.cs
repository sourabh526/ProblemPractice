using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class LinkedListProblem
    {
        //Remove Nth Node from List End
        public ListNode removeNthFromEnd(ListNode A, int B)
        {
            if (B == 0)
            {
                A = A.next;
                return A;
            }
            if(B== 1)
            { return null; }
            ///Find Count
            int listCount = 0;
            ListNode current = A;
            while (current != null)
            {
                listCount++;
                current = current.next;
            }
            int pos = listCount - B;
            deleteNode(A, pos);
            return A;
        }
        private void deleteNode(ListNode A, int pos)
        {
            ListNode prev = A;
            for(int i=0;i < pos-1; i++)
            {
                prev = prev.next;
            }
            prev.next = prev.next.next;
        }

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }        
    }
}
