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
            var PasswordMode = (int)RandomPassword.Mode.NumberUpperLower;
            var retPass = RandomPassword.SetPassword(PasswordMode, 2, 1, 20, 2);
            Console.WriteLine(retPass);
        }
    }
}
