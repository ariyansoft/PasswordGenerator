using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordGenerator;

namespace ChackPassword
{
    public class Program
    {
        static void Main(string[] args)
        {
            var PasswordMode = (int)RandomPassword.Mode.LowerNumberUpper;
            RandomPassword.SetPassword(PasswordMode, 2, 1, 4, 3);
            Console.WriteLine()
        }
    }
}
