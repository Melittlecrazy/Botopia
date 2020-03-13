using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class Timer
    {
        public static void date()
        {
            DateTime now, timezone;
            DateTimeOffset dateOffset1, dateOffset2;
            TimeSpan difference;

            now = DateTime.Now;
            timezone = DateTime.UtcNow;
            difference = now - timezone;
            Console.WriteLine("It's {0} ", now, timezone, difference);
        }
    }
}
