using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            IQueue queue = new MyQueue();
            IOutput output = new Output();

            int limit = 8;
            int min, max;
            Random generator = new Random();

            do
            {
                queue.enqueue(generator.Next(100));

                if (queue.Count > limit)
                    queue.dequeue();

                queue.minimum(out min);
                queue.maximum(out max);
                output.PrintQueue(queue.GetList, min, max);

            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}
