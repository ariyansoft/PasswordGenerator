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
    public class RandomPassword
    {
        public static string RandomString(int size, bool lowerCase)
        {
            var builder = new StringBuilder();
            var random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                //Generate the number and convert it to a character
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();

            return builder.ToString();
        }

        public string SetRandomPassword(int firstLetters, int minNum, int maxNum, int lastLetters)
        {
            var builder = new StringBuilder();
            // First lower case
            builder.Append(RandomString(firstLetters, true));
            builder.Append(RandomNumber.GenerateNumber(minNum, maxNum));
            // last upper case
            builder.Append(RandomString(lastLetters, false));
            return builder.ToString();
        }
    }
}
