using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    internal class RandomNumberGenerator
    {
        private static Random rnd = new Random();
        public static int NumberBetween(int minValue, int maxValue)
        {
            return rnd.Next(minValue, maxValue + 1);
        }
    }
}
