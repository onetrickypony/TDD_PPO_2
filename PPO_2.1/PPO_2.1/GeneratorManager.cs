using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PPO_2._1
{
    class GeneratorManager
    {
        public delegate void EventPrintList(List<int> list, int min, int max);
        public delegate void EventEnqueue(int value);
        public delegate bool EventDequeue();
        public delegate bool EventGetMinimum(out int min);
        public delegate bool EventGetMaximum(out int max);
        public delegate int EventGetCount();
        public delegate List<int> EventGetList();


        public event EventPrintList eventPrintList;
        public event EventEnqueue eventEnqueue;
        public event EventDequeue eventDequeue;
        public event EventGetMinimum eventGetMinimum;
        public event EventGetMaximum eventGetMaximum;
        public event EventGetCount eventGetCount;
        public event EventGetList eventGetList;

        bool is_running;
        int max_queue_size;

        public GeneratorManager(int max_queue_size)
        {
            is_running = true;
            this.max_queue_size = max_queue_size;
        }

        public void Push(int value)
        {
            int count = eventGetCount();
            eventEnqueue(value);

            if (count > max_queue_size - 1)
                eventDequeue();
        }

        public void Run()
        {
            while (is_running)
            {
                int min, max;

                List<int> list = eventGetList();
                eventGetMinimum(out min);
                eventGetMaximum(out max);
                eventPrintList(list, min, max);
                Thread.Sleep(3000);
            }
        }

        public void Stop()
        {
            is_running = false;
        }
    }
}
