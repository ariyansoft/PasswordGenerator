﻿using System;
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
        protected static Random rand = new Random(); 
        public static int GenerateNumber(int min, int max)
        {
            return rand.Next(min, max);
        }
        public static byte[] GenerateNextByte(int max)
        {
            var b = new byte[max];
            rand.NextBytes(b);
            return b;
        }        
    }
}
