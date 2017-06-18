using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PPO_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue queue = new MyQueue();
            IOutput output = new Output();
            Generator generator = new Generator(100);
            GeneratorManager generatorManager = new GeneratorManager(10);

            generator.pushEvent += generatorManager.Push;
            generatorManager.eventPrintList += output.PrintQueue;
            generatorManager.eventDequeue += queue.dequeue;
            generatorManager.eventEnqueue += queue.enqueue;
            generatorManager.eventGetMaximum += queue.maximum;
            generatorManager.eventGetMinimum += queue.minimum;
            generatorManager.eventGetList += queue.GetList;
            generatorManager.eventGetCount += queue.Count;

            Thread controlThread = new Thread(generatorManager.Run);
            Thread generatorThread = new Thread(generator.Run);

            controlThread.Start();
            generatorThread.Start();

            while (Console.ReadKey().Key != ConsoleKey.Escape);

            generator.Stop();
            generatorManager.Stop();
        }
    }
}
