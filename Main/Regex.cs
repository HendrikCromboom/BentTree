using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentTree.Main
{
    static class Regex
    {
        private static string OnlyAlphaNumeric(string str)
        {
            char[] arr = str.ToCharArray();

            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-')));
            str = new string(arr);
            return str;
        }
        private static string OnlyAlphabetic(string str)
        {
            char[] arr = str.ToCharArray();

            arr = Array.FindAll<char>(arr, (c => (char.IsLetter(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-')));
            str = new string(arr);
            return str;
        }
        private static string OnlyNumeric(string str)
        {
            char[] arr = str.ToCharArray();

            arr = Array.FindAll<char>(arr, (c => (char.IsDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-')));
            str = new string(arr);
            return str;
        }
        private static bool IsValidEmail(string str)
        {
            try
            {
                var mailAdress = new System.Net.Mail.MailAddress(str);
                return mailAdress.Address == str;
            }
            catch
            {
                return false;
            }
        }
    }
}
