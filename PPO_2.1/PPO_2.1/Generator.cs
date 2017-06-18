using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PPO_2._1
{
    class Generator
    {
        bool is_running;
        int border;
        Random randomizer;
        public delegate void PushEvent(int number);
        public event PushEvent pushEvent;

        public Generator(int border)
        {
            this.border = border;
            is_running = true;
            randomizer = new Random(DateTime.Now.Millisecond);
        }

        public void Run()
        {
            while (is_running)
            {
                pushEvent(randomizer.Next(border));
                Thread.Sleep(randomizer.Next(100, 5000)); 
            }
        }

        public void Stop()
        {
            is_running = false;
        }
    }
}
