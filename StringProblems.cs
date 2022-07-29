using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProblemPractise
{
    public class StringProblems
    {
        public string reverseString(string str)
        {
            String[] strWords = str.Split(" ");
            StringBuilder ans = new StringBuilder();
            for (int s = strWords.Length - 1; s >= 0; s--)
            {
                if (string.IsNullOrEmpty(ans.ToString()))
                    ans.Append(strWords[s]);
                else ans.Append(" ").Append(strWords[s]);
            }
            return ans.ToString();
        }
        public string rotateString(string str, int d)
        {
            int n = str.Length;
         
            if (n < d)
            {
                return rotateString(str, d % n);
            }
           
            String ans = "";
           
            ans = ans + str.Substring(n - d);

            ans = ans + str.Substring(0, n - d);

            return ans;
        }
        public int periodString(string A)
        {
            int n = A.Length;
            if (n == 1)
                return 1;
            int[] Z = new int[n];
            Zstring(Z, A, n);
            for (int i = 1; i < n; i++)
            {
                if (Z[i] == n - i)
                    return i;
            }
            return n;
        }
        //Z algo
        void Zstring(int[] Z, String A, int n)
        {
            int left = 0, right = 0;
            for (int i = 1; i < n; i++)
            {
                if (i > right)
                {
                    left = right = i;
                    while (right < n && A[right] == A[right - i])
                        right++;
                    Z[i] = right - left;
                    right--;
                }
                else
                {
                    if (Z[i - left] < right - left + 1)
                        Z[i] = Z[i - left];
                    else
                    {
                        left = i;
                        while (right < n && A[right] == A[right - i])
                            right++;
                        Z[i] = right - left;
                        right--;
                    }
                }
            }
        }       
        
    }
    
}
