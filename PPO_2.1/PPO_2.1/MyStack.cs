using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2
{
    public class MyStack // не нужен?
    {
        private Stack<int> stack;

        public Stack<int> Stack
        {
            get{ return stack; }
        }

        public MyStack()
        {
            stack = new Stack<int>();
        }

        public Params Top()
        {
            throw new NotImplementedException();
        }

        public void Push(int elelment)
        {
            throw new NotImplementedException();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }

        public bool CopyFromStack(MyStack stack2)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

    }
}
