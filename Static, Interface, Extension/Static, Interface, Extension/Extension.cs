using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface__Extension
{
    public static class Extension
    {
        public static bool IsOdd(this int num)
        {
            return (num % 2 != 0);
        }
        public static bool IsEven(this int num)
        {
            return (num % 2 == 0);
        }

        public static bool HasDigit(this string text)
        {
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (Char.IsDigit(text[i]))
            //    {
            //        return true;
            //    }
            //}
            //return false;


            //// 2 usulla yazmaq olar

            foreach (char c in text)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckPassword(this string text)
        {
            if (text.Length < 8)
            {
                return false;
            }

            bool CapitalLetter = false;
            bool LowercaseLetter = false;
            bool Number = false;
            foreach (char item in text)
            {
                if (char.IsUpper(item))
                {
                    CapitalLetter = true;
                }
                else if(char.IsLower(item))
                {
                    LowercaseLetter = true;
                }
                else if (char.IsDigit(item))
                {
                    Number = true;
                }
            }
            return CapitalLetter && LowercaseLetter && Number;
        }
        public static string Capitalize(this string text)
        {
            return text.Substring(0,1).ToUpper() + text.Substring(1).ToLower();
        }

    }
}
