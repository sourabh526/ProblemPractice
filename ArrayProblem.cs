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

    }
}
