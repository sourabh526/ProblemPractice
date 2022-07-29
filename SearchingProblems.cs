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
        //Rotated Sorted Array Search
        public int RotatedSortedArraySearch(List<int> A, int k)
        {
            int low = 0, high = A.Count - 1;
            while (low <= high)
            {
                if (low == high && A[low] != k) return -1;
                int mid = (low + high) / 2;
                if (A[mid] == k) return mid;
                if (A[low] < A[mid])
                {
                    if (A[low] <= k && k <= A[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else if (A[mid] < A[high])
                {
                    if (A[mid] <= k && k <= A[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
            }
            return -1;
        }
        //Find a peak element
        public int SearchPeakElement(List<int> A)
        {
            int low = 0, high = A.Count - 1, ans = 0;
            if(A.Count==1)
                return A[0];
            if(A[0]>A[1])
                return A[0];
            if(A[A.Count-1]>A[A.Count - 2])
                return A[A.Count-1];
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (A[mid] >= A[mid - 1] && A[mid] >= A[mid + 1])
                {
                    ans = A[mid];
                    return A[mid];
                }
                if (A[mid - 1] > A[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return ans;
        }
        //Search for a Range
        public List<int> searchRange(List<int> A, int k)
        {
            List<int> ans = new List<int>();
            int low = 0, high = A.Count - 1;
            int[] obj = { -1, -1 };
            if (A.Count == 1)
            {
                int[] obj1 = { 0, 0 };
                ans.AddRange(obj1);
                return ans;
            }
            while (low <= high)
            {               
                int mid = (low + high) / 2;
                if (A[mid] == k && (A[mid]==0 || k > A[mid-1]))
                {
                    ans.Add(mid);
                    break;
                }
                else if (k > A[mid]) low = mid + 1;                
                else high = mid - 1;
            }
            low = 0; high = A.Count - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (((mid == A.Count - 1) || k < A[mid + 1]) && A[mid]== k)
                {
                    ans.Add(mid);
                    break;
                }
                else if(k < A[mid]) high = mid - 1;
                else low = mid +1;
            }
            if(ans.Count == 0)
                ans.AddRange(obj);
            return ans;
        }
        //Ath Magical Number
        public int AthMagicalNumber(int A, int B, int C)
        {
            int low = 0, high = Math.Min(B, C) * A, ans=0;
            int mod = 1000000007;
            while (low<=high)
            {
                int mid = (low + high) / 2;
                int totalMagicNum = (mid / B) + (mid / C) - (mid / (B * C));
                if(totalMagicNum >= A)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }
            return ans% mod;
        }
    }
}

