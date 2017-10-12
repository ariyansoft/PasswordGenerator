using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    /// <summary>
    /// By: Ahmadreza mohebbi
    /// Project Manager at AriyanSoft
    /// </summary>
    public class RandomNumber
    {
        public static int GenerateNumber(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);
        }
    }
}
