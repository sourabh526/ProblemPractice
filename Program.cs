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


            //HashingProblems hp = new HashingProblems();
            //List<int> A = new List<int>(new List<int> { 5, 4, 10, 15, 7, 6 });
            //int B = 5;

            //var ans = hp.SubarrayWithGivenSum(A, 110);
            //var ans = hp.ContiguousArray(A);
            //var ans = hp.PairsWithGivenXor(A, B);


            SearchingProblems search = new SearchingProblems();
            //List<int> A = new List<int>(new List<int> { 1, 3, 5, 6 });
            //int B = 4;

            List<int> A = new List<int>(new List<int> { 3, 4, 18, 19, 20, 27, 28, 31, 36, 42, 44, 71, 72, 75, 82, 86, 88, 97, 100, 103, 105, 107, 110, 116, 118, 119, 121, 122, 140, 141, 142, 155, 157, 166, 176, 184, 190, 199, 201, 210, 212, 220, 225, 234, 235, 236, 238, 244, 259, 265, 266, 280, 283, 285, 293, 299, 309, 312, 317, 335, 341, 352, 354, 360, 365, 368, 370, 379, 386, 391, 400, 405, 410, 414, 416, 428, 433, 437, 438, 445, 453, 457, 458, 472, 476, 480, 485, 489, 491, 493, 501, 502, 505, 510, 511, 520, 526, 535, 557, 574, 593, 595, 604, 605, 612, 629, 632, 633, 634, 642, 647, 653, 654, 656, 658, 686, 689, 690, 691, 709, 716, 717, 737, 738, 746, 759, 765, 775, 778, 783, 786, 787, 791, 797, 801, 806, 815, 820, 822, 823, 832, 839, 841, 847, 859, 873, 877, 880, 886, 904, 909, 911, 917, 919, 937, 946, 948, 951, 961, 971, 979, 980, 986, 993 });
            int B = 902;

            //var ans = search.SearchSingleElement(A);
            var ans = search.searchInsert(A,B);

            //ans.ForEach(x => Console.WriteLine("Output:" + x));
            Console.WriteLine("Output: "+ans);
        }
    }
}
