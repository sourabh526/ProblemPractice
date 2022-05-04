using System;
using System.Collections.Generic;

namespace ProblemPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringProblems sp = new StringProblems();
            //var ans = sp.reverseString("this is blue");
            //var ans = sp.rotateString("jadgbxjesitcdbnbkftdv", 29);
            //var ans = sp.periodString("aaaa");


            ArrayProblem ap = new ArrayProblem();
            List<int> A = new List<int>(new List<int>{ 6, 4, 3, 7, 2, 8 });
            //int A = 5;
            //List<List<int>> B = new List<List<int>>() { 
            //    new List<int> { 1, 2, 10 },
            //    new List<int> { 2, 3, 20 },
            //    new List<int> { 2, 5, 25 },
            //};
            //ap.UniqueElements(A).ForEach(x => Console.WriteLine(x));
            //var ans = ap.UniqueElements(A);
            //var ans = ap.InversionCount(A);
            //var ans = ap.BaggerTemple(A, B);
            var ans = ap.StepwiseSelectionSort(A);
            
            
            
            
            Console.WriteLine("Output: "+ans);
        }
    }
}
