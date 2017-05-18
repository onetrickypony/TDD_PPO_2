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
         
               
            throw new NotImplementedException();
        }

        public void Push(int element)
        {
            throw new NotImplementedException();
        }

        public bool Pop()
        {
            throw new NotImplementedException();
        }

        private bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public List<Params> GetStack
        {
            get { throw new NotImplementedException(); /*return new List<Params>(stack);*/ }
        }

    }
}
