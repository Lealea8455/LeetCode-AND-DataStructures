using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GeneralDS
{
    static public class Questions
    {
        static public string NumberToString(double number)
        {
            double n = number;
            string reversed = "";

            while (n != 0)
            {
                int digit = (int)n % 10;
                char digitChar = (char)(digit + '0');

                reversed += digitChar;
                n = Math.Floor(n / 10);
            }

            string result = "";

            foreach (char c in reversed.Reverse())
            {
                result += c;
            }

            return result;
        }

        static public bool AreTwoStringsAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            Hashtable hash = new Hashtable();

            foreach (char c in str1)
            {
                if (!hash.ContainsKey(c))
                {
                    hash.Add(c, true);
                }
            }


            foreach (char c in str2)
            {
                if (!hash.ContainsKey(c))
                {
                    return false;
                }
            }

            return true;
        }

        static public bool AreTwoStringsAnagrams2(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int[] charsCount = new int[26];

            for (int i = 0; i < str1.Length; i++)
            {
                char c1 = str1[i];
                char c2 = str2[i];

                charsCount[char.ToLower(c1) - 'a'] += 1;
                charsCount[char.ToLower(c2) - 'a'] += 1;
            }

            foreach (int i in charsCount)
            {
                if (i % 2 != 0)
                    return false;
            }

            return true;
        }

        static public string ReplaceSpaces(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (c == ' ')
                {
                    result.Append("%20");
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();

        }

        public static string ReplaceSpaces2(string str)
        {
            int resultStringSize = 0;
            int totalSpaces = 0;

            foreach (char c in str)
            {
                if (c == ' ')
                {
                    totalSpaces += 1;
                }
            }

            resultStringSize = str.Length + totalSpaces * 2;
            char[] resultString = new char[resultStringSize];

            for (int i = 0, j = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    resultString[j] = '%';
                    resultString[j + 1] = '2';
                    resultString[j + 2] = '0';
                    j += 3;
                }
                else
                {
                    resultString[j] = str[i];
                    j += 1;
                }
            }

            string strResult = new string(resultString);
            return strResult;

            //return resultString.ToString();
        }

        public static int Maximum69Number(int num)
        {
            // First we locate the position of the largest*10 6 digit (meaning, if 9696, the largest position of 6 is the hundreds, 3 from right)
            int number = num;
            int biggest6Position = -1;
            int currentDigitPosition = 0;

            while (number > 0)
            {
                if (number % 10 == 6)
                {
                    biggest6Position = currentDigitPosition;
                }

                currentDigitPosition += 1;
                number /= 10;
            }

            if (biggest6Position == -1) return num;

            // Better solution
            // Instead of recreating the number, we will just change the 6 of the position to 9, 
            // by 10^sixindex * 3 + number (if the 6 is in position 2, it should be 60 + 30 to become 90, and so on)  
            return num + (int)Math.Pow(10, biggest6Position) * 3;

            //int i = 0;
            //int result = 0;
            //number = num;

            //while( number != 0)
            //{
            //    if(biggest6Position == i && number % 10 == 6)
            //    {
            //        result += 9 * (int)Math.Pow(10, i);
            //    }
            //    else
            //    {
            //        result += number % 10 * (int)Math.Pow(10, i);
            //    }

            //    i++;
            //    number /= 10;
            //}

            //return result;
        }

        public static bool IsSubString(string s1, string s2)
        {
            string concatenate = string.Concat(s1, s1);

            // now check if one of the strings exists in the concatenated string
            for (int i = 0, j = 0; i < concatenate.Length; i++)
            {
                if (concatenate[i] == s2[j]) j++;
                else if (j > 0) return false;

                if (j == s2.Length) return true;
            }

            return false;
        }

        public static int[] SmallerNumbersThanCurrent(int[] numbers)
        {
            int size = numbers.Length;
            int[] result = new int[size];
            int counter = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        counter++;
                    }
                }
                result[i] = counter;
                counter = 0;
            }

            return result;
        }

        public static bool PalindromePermutation(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            if (str.Length == 0 || str == null) return false;

            foreach (char c in str)
            {
                if (!charCount.ContainsKey(c))
                {
                    charCount.Add(c, 1);
                }
                else
                {
                    charCount[c] += 1;  
                }
            }

            int oddCharAppearenceAmount = 0;

            foreach (var item in charCount)
            {
                if (item.Value % 2 != 0)
                {
                    if (oddCharAppearenceAmount == 0 && str.Length % 2 > 0) oddCharAppearenceAmount++;
                    else return false;
                }
            }

            return true;
        }

        public static string StringCompression(string str)
        {
            Dictionary<char, int> charAndItsOccurrence = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!charAndItsOccurrence.ContainsKey(c))
                {
                    charAndItsOccurrence.Add(c, 1);
                }
                else
                {
                    charAndItsOccurrence[c]++;
                }
            }

            StringBuilder compressed = new StringBuilder();

            foreach (KeyValuePair<char, int> pair in charAndItsOccurrence)
            {
                compressed.Append(pair.Key);
                compressed.Append(pair.Value).ToString();
            }

           
            if (compressed.Length >= str.Length) return str;
            else return compressed.ToString();
        }


    }
}
