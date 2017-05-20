using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2._1
{
    interface IOutput
    {
        void PrintQueue(List<int> queue, int min, int max);
    }
}
