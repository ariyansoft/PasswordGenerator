using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    /// <summary>
    /// By: Ahmadreza mohebbi
    /// </summary>
    public class RandomNumber
    {
        public static int GenerateNumber(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);
        }

        public static byte[] GenerateNextByte(int max)
        {
            var b = new byte[max];
            var rnd = new Random();
            rnd.NextBytes(b);
            return b;
        }
    }
}
