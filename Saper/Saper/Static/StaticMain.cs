using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper.Static
{
    public static class StaticMain
    {
        public static int BombQuantity { get; set; }
        public static int FlagsQuntity { get; set; }
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        //CalculatorHelper.RandomNumber()
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }


    }
}
