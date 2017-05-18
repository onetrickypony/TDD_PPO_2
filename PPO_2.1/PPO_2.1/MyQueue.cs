using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2
{
    public class MyQueue
    {
        MyStack head;
        MyStack tail;

        public MyQueue()
        {
            head = new MyStack();
            tail = new MyStack();
        } 

        public void enqueue(int value)
        {
            //head.Push(new Params();
            throw new NotImplementedException();
        }

        public bool dequeue()
        {
            throw new NotImplementedException();
        }

        public bool minimum(out int value)
        {
            throw new NotImplementedException();
        }

        public bool maximum(out int value)
        {
            throw new NotImplementedException();
        }

        private bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public List<int> GetList
        {
            get
            {
                throw new NotImplementedException();
                /*
                List<int> result = new List<int>();
                List<Params> copy_of_head = new List<Params>(head);
                List<Params> copy_of_tail = new List<Params>(tail);

                copy_of_tail.Reverse();
                copy_of_tail.AddRange(copy_of_head);

                for (int i = 0; i < copy_of_tail.Count; i++)
                    result.Add(copy_of_tail[i].Value);

                return result;
                */
            }
        }

    }
}
