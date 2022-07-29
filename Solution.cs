using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractise
{
    internal class Solution
    {
        public int kthsmallest(List<int> A, int B)
        {
            // A.Sort();
            // return A[B-1];
            if (A.Count == 1)
                return A[0];
            if (A.Count == 2 && (A[0] < A[1] && (B == 2 || B == 1)))
            return A[B - 1];

            quickSort(A, 0, A.Count - 1);
            return A[B - 1];

        }
        public void quickSort(List<int> arr, int low, int high)
        {
            if (low < high)
            {

                // pi is partitioning index, arr[p]
                // is now at right place
                int pi = partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
        public int partition(List<int> arr, int low, int high)
        {
            // pivot
            int pivot = arr[high];

            // Index of smaller element and
            // indicates the right position
            // of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                // If current element is smaller
                // than the pivot
                if (arr[j] < pivot)
                {

                    // Increment index of
                    // smaller element
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }
        public void swap(List<int> arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }        
    }
}
