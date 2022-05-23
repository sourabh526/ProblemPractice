using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class SearchingProblems
    {
        //Single Element in a Sorted Array
        public int SearchSingleElement(List<int> A)
        {
            int ans = 0, n = A.Count;
            int low = 0, high = n - 1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                if (mid == n - 1)
                    return A[n - 1];
                if (A[mid] == A[mid + 1])
                    mid++;
                // if all elements with index < mid are occuring twice then mid should be odd
                if (mid % 2 == 1)
                    low = mid + 1;
                else
                {
                    ans = mid;
                    high = mid - 1;
                }
            }
            return A[ans];
        }
        //Sorted Insert Position       
        public int searchInsert(List<int> A, int B)
        {
            int ans = 0, n = A.Count;
            int low = 0, high = n - 1;
            if (A[low] == B)
                return low;
            if(A[high] == B)
                return high;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                if (A[mid] == B)
                    return mid;               
                // if all elements with index < mid are occuring twice then mid should be odd
                if (A[mid] < B)
                    low = mid + 1;
                else
                {
                    ans = mid;
                    high = mid - 1;
                }
            }
            if (ans == 0 && A[n - 1] < B)
                ans = n;
            return ans;
        }
    }
}
