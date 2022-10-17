using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    internal class StackImp
    {
        public class MyStack
        {
            private List<int> stack = new List<int>();
            private List<int> maxStack = new List<int>();

            public int peek()
            {
                if (isEmpty())
                    throw new Exception("Stack is empty! You can't peek");

                return stack[stack.Count-1];
            }

            public bool isEmpty()
            {
                return (stack.Count == 0?true:false);
            }

            public int pop()
            {
                if (isEmpty())
                    throw new Exception("Stack is empty! You can't pop");

                int element= stack[stack.Count - 1];
                stack.Remove(element);
                maxStack.RemoveAt(maxStack.Count - 1);
                return element;
            }

            public void push(int num)
            {
                stack.Add(num);
                if (maxStack.Count > 0)
                {
                    if (maxStack[maxStack.Count - 1] >= num)
                    {
                        maxStack.Add(maxStack[maxStack.Count - 1]);
                    }
                    else
                        maxStack.Add(num);
                }
                else
                    maxStack.Add(num);
            }

            public void Clear()
            {
                stack.Clear();
            }

            public int getMax()
            {
                return maxStack[maxStack.Count - 1];
            }
        }

        public static int Main()
        {
            MyStack st = new MyStack();
            try
            {
                st.push(4);
                st.push(1);
                Console.WriteLine($"Max: {st.getMax()}");

                st.push(7);
                Console.WriteLine($"Max: {st.getMax()}");

                st.push(3);
                Console.WriteLine($"Max: {st.getMax()}");

                Console.WriteLine($"poped: {st.pop()}");
                Console.WriteLine($"Max: {st.getMax()}");
                Console.WriteLine($"poped: {st.pop()}");
                Console.WriteLine($"Max: {st.getMax()}");
                Console.WriteLine($"isEmpty: {st.isEmpty()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
            return 1;
        }
    }
}
