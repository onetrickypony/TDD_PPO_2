using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2
{
    public class MyStack 
    {
        private Stack<Params> stack;

        public MyStack()
        {
            stack = new Stack<Params>();
        }

        public bool Peek(out Params peek)
        {
            bool result;

            if (this.IsEmpty())
            {
                peek = new Params();
                result = false;
            }
            else
            {
                peek = stack.Peek();
                result = true;
            }
            return result;
        }

        public void Push(int element)
        {
            if (this.IsEmpty())
                stack.Push(new Params(element, element, element));
            else
            {
                int min = Math.Min(element, stack.Peek().MinValue);
                int max = Math.Max(element, stack.Peek().MaxValue);
                stack.Push(new Params(element, max, min));
            }
        }

        public bool Pop(out Params element)
        {
            bool result;
            if (stack.Count == 0)
            {
                element = new Params();
                result = false;
            }
            else
            {
                element = stack.Pop();
                result = true;
            }
            return result;
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public void CopyFromAnotherStack(MyStack other_stack)
        {
            stack.Clear();
            while (!other_stack.IsEmpty())
            {
                Params temp = new Params();
                if (other_stack.Pop(out temp))
                    this.Push(temp.Value);
            }
        }

        public List<Params> GetStack
        {
            get { return new List<Params>(stack); }
        }

    }
}
