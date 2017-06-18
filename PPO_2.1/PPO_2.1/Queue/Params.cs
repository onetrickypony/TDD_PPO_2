using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO_2
{
    public class Params
    {
        private int value;
        private int maxvalue;
        private int minvalue;


        public int Value
        {
            get { return value; }
        }

        public int MaxValue
        {
            get { return maxvalue; }
        }

        public int MinValue
        {
            get { return minvalue; }
        }

        public Params(int value, int maxvalue, int minvalue)
        {
            this.value = value;
            this.maxvalue = maxvalue;
            this.minvalue = minvalue;
        }

        public Params()
        {
            this.value = 0;
            this.maxvalue = 0;
            this.minvalue = 0;
        }

        public static bool operator ==(Params left, Params right)
        {
            if (left.MaxValue == right.MaxValue && left.MinValue == right.MinValue && left.Value == right.Value)
                return true;
            else
                return false;
        }

        public static bool operator !=(Params left, Params right)
        {
            if (left.MaxValue == right.MaxValue && left.MinValue == right.MinValue && left.Value == right.Value)
                return false;
            else
                return true;
        }
    }
}
