using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class Utility
    {
        public static void Print(string _message)
        {
            WriteLine(_message);
        }
        public static Random RanNum = new Random();
        internal enum Suit : byte
        {
            Clubs,
            Spades,
            Diamonds,
            Hearts
        }
    }
}
