using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemPractice
{
    internal class StackProblem
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> minStack = new Stack<int>();

        public StackProblem()
        {
            this.stack = new Stack<int>();
            this.minStack = new Stack<int>();
        }

        public void push(int x)
        {
            stack.Push(x);
            if (minStack.Count == 0 || x <= minStack.Peek())
                minStack.Push(x);
        }
        public void pop()
        {
            if (stack.Count != 0) {
                int num = stack.Pop();
                if (num == minStack.Peek())
                    minStack.Pop();
            }
               
        }
        public int top()
        {
            if (stack.Count == 0)
                return -1;

            return stack.Peek();
        }
        public int getMin()
        {
            if (minStack.Count == 0)
                return -1;

            return minStack.Peek();
        }

        public List<int> sortStack(List<int> A)
        {
            Stack<int> sortStack = new Stack<int>();
            Stack<int> inputStack = new Stack<int>();
            List<int> outputStack = new List<int>();

            foreach (int x in A)
            {
                inputStack.Push(x);
            }
            while(inputStack.Count > 0)
            {
                int temp = inputStack.Pop();
                
                while(sortStack.Count>0 && sortStack.Peek()>temp)
                {
                    inputStack.Push(sortStack.Pop());
                }

                sortStack.Push(temp);
            }
            foreach (int item in sortStack)
            {
                outputStack.Add(item);
            }
            return outputStack;
        }
    }
}
