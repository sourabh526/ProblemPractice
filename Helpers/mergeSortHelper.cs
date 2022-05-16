using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractise
{
    internal class mergeSortHelper
    {
        
        public int mergeSort(List<int> arr, int left, int right )
        {
            int mid, inv_count = 0;
            if (right > left)
            {
                mid = (right + left) / 2;
                int[] tmp = new int[arr.Count];
                inv_count += mergeSort(arr, left, mid);
                inv_count += mergeSort(arr, mid + 1, right);

                //Merging
                inv_count +=  merge(arr,tmp, left, mid + 1, right);
            }
            return inv_count;
        }
        private int merge(List<int> arr,int[] tmp, int left, int mid, int right)
        {
            int i, j, k;
            int inv_count = 0;
            
            i = left; /* i is index for left subarray*/
            j = mid; /* j is index for right subarray*/
            k = left; /* k is index for resultant merged
                     subarray*/
            while ((i <= mid - 1) && (j <= right))
            {
                if (arr[i] <= arr[j])
                {
                    tmp[k++] = arr[i++];
                }
                else
                {
                    tmp[k++] = arr[j++];

                    /*this is tricky -- see above
                     * explanation/diagram for merge()*/
                    inv_count = inv_count + (mid - i);
                }
            }

            /* Copy the remaining elements of left subarray
           (if there are any) to temp*/
            while (i <= mid - 1)
                tmp[k++] = arr[i++];

            /* Copy the remaining elements of right subarray
           (if there are any) to temp*/
            while (j <= right)
                tmp[k++] = arr[j++];

            /*Copy back the merged elements to original array*/
            for (i = left; i <= right; i++)
                arr[i] = tmp[i];

            return inv_count;
        }
    }
}
