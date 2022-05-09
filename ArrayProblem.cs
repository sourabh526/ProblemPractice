using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractise
{
    internal class ArrayProblem
    {
        quickSortAlgo quickSortAlgo = new quickSortAlgo();
        mergeSortHelper mergeHelper = new mergeSortHelper();
        public int UniqueElements(List<int> A)
        {
            int n = A.Count;
            int count = 0;
            
           quickSortAlgo.quickSort(A,0,n-1);
           for(int i=1;i<=n-1;i++)
            {
                if(A[i] == A[i-1])
                {
                    A[i] = A[i]+1;
                    count++;
                }
                else if(A[i] < A[i-1])
                {
                    int addCount = ((A[i - 1]) + 1) - A[i];
                    A[i] = A[i] + addCount;
                    count = count + addCount;   
                }
            }
           return count;
        }
        public int InversionCount(List<int> A)
        {
            int left = 0;
            int right = A.Count-1;
           
            return mergeHelper.mergeSort(A,left,right);
        }
        public List<int> BaggerTemple(int A, List<List<int>> B)
        {
            List<int> result = new List<int>();
            for (int k = 0; k < A; k++)
            {
                result.Add(0);
            }
            for (int i=0;i<B.Count;i++)
            {
                int L = (B[i][0]) - 1;
                int R = (B[i][1]);
                result[L] += B[i][2];
                if (R < A)
                    result[R] += -B[i][2];
            }
            //prefix sum
            for(int j=1;j<result.Count;j++)
            {
                result[j] += result[j-1];
            }
            return result;
        }
        public List<int> StepwiseSelectionSort(List<int> A)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < A.Count-1; i++)
            {
                int min_index = i;

                for (int j =i+1; j< A.Count;j++)
                {
                    if (A[j] < A[min_index])
                        min_index = j;
                }
                //swap min element
                int swapValue = A[min_index];
                A[min_index] = A[i];
                A[i] = swapValue;
                result.Add(min_index);
            }
            return result;
        }
        public int SumTheDifference(List<int> A)
        {
            int MOD = 1000000007;
            A.Sort();
            int n = A.Count;
            long min_sum = 0, max_sum = 0;
            for (int i = 0; i < n; i++)
            {
                max_sum = 2 * max_sum + A[n - 1 - i];
                max_sum %= MOD;
                min_sum = 2 * min_sum + A[i];
                min_sum %= MOD;
            }
            return (int)((max_sum - min_sum + MOD) % MOD);
        }

        public List<int> MergeTwoSortedArrays(List<int> A, List<int> B)
        {
            int i = 0, j = 0, k = 0;
            List<int> result = new List<int>();
            int n1 = A.Count;
            int n2 = B.Count;

            // Traverse both array
            while (i < n1 && j < n2)
            {
                // Check if current element
                // of first array is smaller
                // than current element
                // of second array. If yes,
                // store first array element
                // and increment first array
                // index. Otherwise do same
                // with second array
                if (A[i] < B[j])
                {
                    result.Add(A[i]);
                    i++;
                }
                else
                {
                    result.Add(B[j]);
                    j++;
                }
                   
            }

            // Store remaining
            // elements of first array
            while (i < n1)
            {
                result.Add(A[i]);
                i++;
            }

            // Store remaining elements
            // of second array
            while (j < n2)
            {
                result.Add(B[j]);
                j++;
            }
            return result;
        }
        //Pascal’s Triangle
        public List<List<int>> PascalTriangle(int numRow)
        {
            List<List<int>> result = new List<List<int>>();
            for(int i = 0; i < numRow; i++)
            {
                if(i==0)
                    result.Add(new List<int>() {1});
                else if(i==1)
                    result.Add(new List<int>() { 1,1 });
                else
                {
                    List<int> newRow = new List<int>();
                    newRow.Add(1);
                    for(int j = 0; j < i-1; j++)
                    {
                        newRow.Add(result[i - 1][j] + result[i - 1][j + 1]);
                    }
                    newRow.Add(1);
                    result.Add(newRow);
                }                
            }
            return result;
        }
        
        //Kth Smallest Element
        public int kthsmallest(List<int> A, int B)
        {
            int n = A.Count;           
            quickSortAlgo.quickSort(A, 0, n - 1);
            return A[B-1];
        }
        
        //Non decreasing subarray queries
        public List<int> NonDecreasingSubarray(List<int> A, List<List<int>> B)
        {
            List<int> result = new List<int>();
            bool flag = false;
            for (int i = 0; i < B.Count; i++)
            {
                for (int j = (B[i][0] - 1); j < (B[i][1]- 1); j++)
                {
                    if (A[j] <= A[j + 1])
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    result.Add(1);
                else
                    result.Add(0);
            }
            return result;
        }

    }
}
