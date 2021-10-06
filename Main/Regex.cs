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
        private static string RemoveWhiteSpaces(string str)
        {
            char[] arr = str.ToCharArray();
            arr = Array.FindAll<char>(arr, (c => (!char.IsWhiteSpace(c))));
            str = new string(arr);
            return str;
        }
        private static string RemoveDuplicateWhiteSpaces(string str)
        {
            var list = str.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s));
            str = string.Join(" ", list);
            return str;
        }
        private static int CountWords(string str)
        {
            int count = 0, i = 0;

            while (i < str.Length && char.IsWhiteSpace(str[i]))
                i++;

            while (i < str.Length)
            {
                while (i < str.Length && !char.IsWhiteSpace(str[i]))
                    i++;

                count++;

                while (i < str.Length && char.IsWhiteSpace(str[i]))
                    i++;
            }
            return count;

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
