using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2._1
{
    class Output : IOutput
    {
        public Output() { }

        public void PrintQueue(List<int> queue, int min, int max)
        {
            Console.Clear();
            Console.Write("queue: ");
            for (int i = 0; i < queue.Count; i++)
                Console.Write(queue[i] + " ");
            Console.WriteLine("\nmax: {0}\nmin: {1}", max, min);
        }
    }
}
