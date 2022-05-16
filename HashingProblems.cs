using ProblemPractice.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class HashingProblems
    {
        //Subarray with given sum
        stringHelpers stringHelpers = new stringHelpers();
        public List<int> SubarrayWithGivenSum(List<int> A, int B)
        {
            List<int> result = new List<int>();           
            int sum = A[0];           
            int start = 0;
            for (int i = 1; i < A.Count; i++)
            {
                if (i < A.Count)
                {
                    sum = sum + A[i];
                }
                while (sum > B && start < A.Count)
                {
                    sum = sum - A[start];
                    start++;
                }
                if (sum == B)
                {    
                    for(int j=start; j < i+1; j++)
                        result.Add(A[j]);
                    return result;
                }
                
            }
            if (result.Count == 0)
                result.Add(-1);
            return result;
        }

        //Replicating Substring
        public int ReplicatingSubstring(int A, string B)
        {
            if (A == 1)
                return 1;
            Dictionary<string, int> alphaCount = new Dictionary<string, int>();
            for(int i=0;i<B.Length;i++)
            {
                if (alphaCount.ContainsKey(B[i].ToString())) 
                {
                    alphaCount[B[i].ToString()]++;
                }
                else
                    alphaCount.Add(B[i].ToString(), 1);
            }
            for(int j=0; j < B.Length; j++)
            {
                if ((alphaCount[B[j].ToString()] % A) != 0)
                    return -1;
                    
            }
            return 1;
        }
        //Contiguous Array
        public int ContiguousArray(List<int> A)
        {
            Dictionary<int, int> prefixSumarr = new Dictionary<int, int>();
            int result = 0, len =0;
            if (A[0] == 0)
                A[0] = -1;
            //prefix array
            for (int i=1;i<A.Count;i++)
            {
                if (A[i] == 0)
                    A[i] = -1;
                A[i] = A[i-1] + A[i];   
            }
            for(int i=0;i < A.Count; i++) 
            {
                if(prefixSumarr.ContainsKey(A[i]))
                    len = i - prefixSumarr[A[i]];
                else
                {
                    prefixSumarr.Add(A[i], i);
                }
                result = Math.Max(len, result);
            }
            return result;
        }
    }
}
