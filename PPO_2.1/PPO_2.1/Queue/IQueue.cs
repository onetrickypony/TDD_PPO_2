using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2._1
{
    interface IQueue
    {
        void enqueue(int value);
        bool dequeue();
        bool minimum(out int min);
        bool maximum(out int max);
        List<int> GetList();
        int Count();
    }
}
