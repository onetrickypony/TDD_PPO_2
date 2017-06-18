using PPO_2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2
{
    public class MyQueue : IQueue
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
            head.Push(value);
        }

        public bool dequeue()
        {
            bool result = true;

            if (this.IsEmpty())
            {
                result = false;
            }
            else if (tail.IsEmpty())
            {
                Params temp = new Params();
                tail.CopyFromAnotherStack(head);
                tail.Pop(out temp);
            }
            else
            {
                Params temp = new Params();
                tail.Pop(out temp);
            }
            return result;
        }

        public bool minimum(out int min)
        {
            bool result = true;
            min = 0;
            Params temp_head = new Params();
            Params temp_tail = new Params();

            if (this.IsEmpty())
            {
                result = false;
            }
            else if (head.IsEmpty() || tail.IsEmpty())
            {
                bool is_head = head.Peek(out temp_head);
                bool is_tail = tail.Peek(out temp_tail);
                if (is_head)
                    min = temp_head.MinValue;
                else
                    min = temp_tail.MinValue;
            }
            else
            {
                head.Peek(out temp_head);
                tail.Peek(out temp_tail);
                min = Math.Min(temp_head.MinValue, temp_tail.MinValue);
            }
            return result;
        }

        public bool maximum(out int max)
        {
            bool result = true;
            max = 0;
            Params temp_head = new Params();
            Params temp_tail = new Params();

            if (this.IsEmpty())
            {
                result = false;
            }
            else if (head.IsEmpty() || tail.IsEmpty())
            {
                bool is_head = head.Peek(out temp_head);
                bool is_tail = tail.Peek(out temp_tail);
                if (is_head)
                    max = temp_head.MaxValue;
                else
                    max = temp_tail.MaxValue;
            }
            else
            {
                head.Peek(out temp_head);
                tail.Peek(out temp_tail);
                max = Math.Max(temp_head.MaxValue, temp_tail.MaxValue);
            }
            return result;
        }

        private bool IsEmpty()
        {
            return tail.IsEmpty() && head.IsEmpty();
        }

        public List<int> GetList()
        {               
            List<int> result = new List<int>();
            List<Params> copy_of_head = new List<Params>(head.GetStack);
            List<Params> copy_of_tail = new List<Params>(tail.GetStack);

            copy_of_tail.Reverse();
            copy_of_tail.AddRange(copy_of_head);

            for (int i = 0; i < copy_of_tail.Count; i++)
                result.Add(copy_of_tail[i].Value);

            return result;               
            
        }

        public int Count()
        {
            return head.GetStack.Count + tail.GetStack.Count;
        }

    }
}
