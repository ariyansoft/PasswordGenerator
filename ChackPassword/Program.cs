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
            //var PasswordMode = (int)RandomPassword.Mode.UpperNumberLower;
            //var retPass = RandomPassword.SetPassword(PasswordMode, 5, 1, 200, 5);
            //Console.WriteLine(retPass + RandomNumber.GenerateNonAlphanumeric(2));
            Console.WriteLine();
            var ShufflePass = RandomPassword.ShufflePassword(50);
            Console.WriteLine(ShufflePass);
        }
    }
}
