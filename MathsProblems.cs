using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class MathsProblems
    {
        //Number Of Open Doors
        public int NumberOfOpenDoors(int A)
        {
            int count = 0;
            for(int i=1;i<= Math.Sqrt(A);i++)
            {                
                if(Math.Pow(i, 2)>=1 && Math.Pow(i, 2)<=A)
                {
                    count++;
                }
            }
            return count;
        }
        //Count of divisors
        public List<int> CountOfDivisors(List<int> A)
        {
            List<int> result = new List<int>();
            for(int i=0;i<A.Count;i++)
            {
                int count = 0;
                for(int j=1;j<=A[i];j++)
                {
                    if((A[i]%j)==0)
                    {
                        count++;
                    }
                }
                result.Add(count);
            }
            return result;
        }
    }
}
