using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    /// <summary>
    /// By: Ahmadreza mohebbi
    /// </summary>
    public class RandomPassword
    {
        public enum Mode
        {
            /// <summary>
            /// Lower: lower case
            /// Upper: upper case
            /// </summary>
            LowerNumberUpper = 1, UpperNumberLower, NumberUpperLower, NumberLowerUpper
        };

        public static string SetPassword(int Mode, int param1, int param2, int param3, int param4)
        {
            try
            {
                var PassStr = string.Empty;
                switch (Mode)
                {
                    case 1:
                        PassStr = SetLowerNumberUpper(param1, param2, param3, param4);
                        break;
                    case 2:
                        PassStr = SetUpperNumberLower(param1, param2, param3, param4);
                        break;
                    case 3:
                        PassStr = SetNumberUpperLower(param1, param2, param3, param4);
                        break;
                    case 4:
                        PassStr = SetNumberLowerUpper(param1, param2, param3, param4);
                        break;
                }
                return PassStr;
            }
            catch(Exception)
            {
                throw new ArgumentException("Notice the values of the parameters");
            }
        }

        protected static string SetLowerNumberUpper(int firstLetters, int minNum, int maxNum, int lastLetters)
        {
            var builder = new StringBuilder();
            builder.Append(RandomString(firstLetters, true));
            if(minNum > maxNum)
              {
                 return "The second parameter of the third parameter must be smaller";                    
              }
              else
              {
                 builder.Append(RandomNumber.GenerateNumber(minNum, maxNum));
                 builder.Append(RandomString(lastLetters, false));
              }            
            return builder.ToString();
        }

        protected static string SetUpperNumberLower(int firstLetters, int minNum, int maxNum, int lastLetters)
        {
            var builder = new StringBuilder();
            builder.Append(RandomString(firstLetters, false));
            if(minNum > maxNum)
              {
                 return "The second parameter of the third parameter must be smaller";                    
              }
            else
              {
                 builder.Append(RandomNumber.GenerateNumber(minNum, maxNum));
                 builder.Append(RandomString(lastLetters, true));
              }          
            return builder.ToString();
        }

        protected static string SetNumberUpperLower(int minNum, int maxNum, int firstLetters, int lastLetters)
        {
            var builder = new StringBuilder();     
            if(minNum > maxNum)
              {
                 return "The first parameter of the second parameter must be smaller";  
              }
            else
                {
                    builder.Append(RandomNumber.GenerateNumber(minNum, maxNum));
                    builder.Append(RandomString(firstLetters, false));
                    builder.Append(RandomString(lastLetters, true));
                }
            
            return builder.ToString();
        }

        protected static string SetNumberLowerUpper(int minNum, int maxNum, int firstLetters, int lastLetters)
        {
            var builder = new StringBuilder();
            if(minNum > maxNum)
              {
                 return "The first parameter of the second parameter must be smaller";  
              }
            else
              {
                 builder.Append(RandomNumber.GenerateNumber(minNum, maxNum));
                 builder.Append(RandomString(firstLetters, true));
                 builder.Append(RandomString(lastLetters, false));
              }            
            return builder.ToString();
        }

        protected static string RandomString(int size, bool lowerCase)
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
    }
}
