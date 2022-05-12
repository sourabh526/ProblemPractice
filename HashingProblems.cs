using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class HashingProblems
    {
        //Subarray with given sum
        public List<int> SubarrayWithGivenSum(List<int> A, int B)
        {
            List<int> result = new List<int>();
            A.Sort();
            int sum = A[0];           
            int start = 0;
            for (int i = 1; i < A.Count; i++)
            {
                while (sum > B && start < i - 1)
                {
                    sum = sum - A[start];
                    start++;
                }
                if (sum == B)
                {    
                    for(int j=start; j < i; j++)
                        result.Add(A[j]);
                    return result;
                }
                if (i < A.Count)
                {                    
                    sum = sum + A[i];                    
                }
            }
            if (result.Count == 0)
                result.Add(-1);
            return result;
        }
    }
}
