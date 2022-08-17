using ProblemPractice;
using System;
using System.Collections.Generic;

namespace ProblemPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringProblems sp = new StringProblems();
            //var ans = sp.reverseString("this is blue");
            //var ans = sp.rotateString("jadgbxjesitcdbnbkftdv", 29);
            //var ans = sp.periodString("aaaa");
            //var ans = sp.isBase64("91TFAgR9cMwVe8sJk1CvpZty3Z6Q7Vwy4Y/vRFvwGF1oMl6VHusFBpWBRYaf44qo");
            //var ans = sp.isBase64("sddaa sdsd");


            //ArrayProblem ap = new ArrayProblem();
            //List<int> A = new List<int>(new List<int> { 7, 7, 1, 6, 9 });
            //List<int> B = new List<int>(new List<int> { 2, 11, 19 });
            //int B = 9;
            //List<List<int>> B = new List<List<int>>() {
            //    new List<int> { 1, 3 },
            //    new List<int> { 4, 5 },
            //    new List<int> { 1, 2 },
            //    new List<int> { 3, 4 },
            //    new List<int> { 1, 5 },
            //};
            //ap.UniqueElements(A).ForEach(x => Console.WriteLine(x));
            //var ans = ap.UniqueElements(A);
            //var ans = ap.InversionCount(A);
            //var ans = ap.BaggerTemple(A, B);            
            //var ans = ap.StepwiseSelectionSort(A);
            //var ans = ap.SumTheDifference(A);
            //var ans = ap.MergeTwoSortedArrays(A, B);
            //var ans = ap.PascalTriangle(5);
            //var ans = ap.kthsmallest(A, B);
            //var ans = ap.NonDecreasingSubarray(A, B);  

            //TreeProblem tp = new TreeProblem();
            //List<int> A = new List<int>(new List<int> { 1, 2, 3 });
            //List<int> B = new List<int>(new List<int> { 2, 1, 3 });

            //var ans = tp.buildTree(A, B);

            //MathsProblems mp = new MathsProblems();
            //List<int> A = new List<int>(new List<int> { 2, 3, 4, 5 });


            //var ans = mp.CountOfDivisors(A);


            //HashingProblems hp = new HashingProblems();
            //List<int> A = new List<int>(new List<int> { 5, 4, 10, 15, 7, 6 });
            //int B = 5;

            //var ans = hp.SubarrayWithGivenSum(A, 110);
            //var ans = hp.ContiguousArray(A);
            //var ans = hp.PairsWithGivenXor(A, B);


            //SearchingProblems search = new SearchingProblems();
            //List<int> A = new List<int>(new List<int> { 1, 3, 5, 6 });
            //int B = 4;

            //List<int> A = new List<int>(new List<int> { 1,1,2 });
            //int B = 1;

            //var ans = search.SearchSingleElement(A);
            //var ans = search.searchInsert(A,B);
            //var ans = search.RotatedSortedArraySearch(A, B);
            //var ans = search.SearchPeakElement(A);
            //var ans = search.searchRange(A, B);
            //var ans = search.AthMagicalNumber(14, 10, 12);

            //ans.ForEach(x => Console.WriteLine("Output:" + x));

            //Solution solution = new Solution();
            //List<int> A = new List<int>(new List<int> { 2, 1, 4, 3, 2 });
            //int B = 2;
            //var ans = solution.kthsmallest(A, B);


            //StackProblem stackProblem = new StackProblem();
            //List<int> A = new List<int>(new List<int> { 5, 17, 100, 11 });
            //var ans = stackProblem.sortStack(A);

            LinkedListProblem llp = new LinkedListProblem();
            ListNode node1 = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(3);
            //ListNode node4 = new ListNode(4);
            //ListNode node5 = new ListNode(5);
            //ListNode node6 = new ListNode(6);

            ListNode head = node1;
            head.next = null;
            //head.next = node2;
            //node2.next = node3;
            //node3.next = node4;
            //node4.next = node5;
            //node5.next = node6;
            //node6.next = null;

            var ans = llp.removeNthFromEnd(head, 1);
            ListNode current = ans;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }

            //ans.ForEach(x => Console.WriteLine("Output:" + x));
        }
    }
}
