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
            var PasswordMode = (int)RandomPassword.Mode.ShufflePassword;            
            var retPass = RandomPassword.SetPassword(PasswordMode, 10,15,0,0);
            Console.WriteLine(retPass);
        }
    }
}
