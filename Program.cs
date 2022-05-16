using ProblemPractice;
using System;
using System.Collections.Generic;

namespace ProblemPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringProblems sp = new StringProblems();
            //var ans = sp.reverseString("this is blue");
            //var ans = sp.rotateString("jadgbxjesitcdbnbkftdv", 29);
            //var ans = sp.periodString("aaaa");


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


            HashingProblems hp = new HashingProblems();
            List<int> A = new List<int>(new List<int> { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 1 });

            //var ans = hp.SubarrayWithGivenSum(A, 110);
            var ans = hp.ContiguousArray(A);

            //ans.ForEach(x => Console.WriteLine("Output:" + x));
            Console.WriteLine("Output: "+ans);
        }
    }
}
