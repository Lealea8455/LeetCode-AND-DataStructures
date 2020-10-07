using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneralDS;
using System.Security.Cryptography;

namespace GeneralQuestionsTests
{
    [TestClass]
    public class QuestionsTests
    {
        [TestMethod]
        public void NumberToString()
        {
            double number = 42685;
            string expected = "42685";

            string actual = Questions.NumberToString(number);

            Assert.AreEqual(expected, actual, "convertion failed");
        }

        [TestMethod]
        public void AreTwoStringsAnagramsTest()
        {
            string s1 = "silent";
            string s2 = "listen";

            bool expected = true;

            bool actual = Questions.AreTwoStringsAnagrams(s1, s2);

            Assert.AreEqual(actual, expected);

            // This time false 
            s1 = "silent";
            s2 = "listeg";

            expected = false;

            actual = Questions.AreTwoStringsAnagrams(s1, s2);

            Assert.AreEqual(actual, expected);

            // One more example case
            s1 = "dogo";
            s2 = "hogo";

            expected = false;

            actual = Questions.AreTwoStringsAnagrams(s1, s2);

            Assert.AreEqual(actual, expected);

            // Different sizes case
            s1 = "dogoLong";
            s2 = "dogo";

            expected = false;

            actual = Questions.AreTwoStringsAnagrams(s1, s2);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AreTwoStringsAnagrams2Test()
        {
            string s1 = "silent";
            string s2 = "listen";

            bool expected = true;

            bool actual = Questions.AreTwoStringsAnagrams2(s1, s2);

            Assert.AreEqual(actual, expected);

            //This time false 
            s1 = "silent";
            s2 = "listeg";

            expected = false;

            actual = Questions.AreTwoStringsAnagrams2(s1, s2);

            Assert.AreEqual(actual, expected);

            //// One more example case
            s1 = "dogo";
            s2 = "hogo";

            expected = false;

            actual = Questions.AreTwoStringsAnagrams2(s1, s2);

            Assert.AreEqual(actual, expected);

            // Different sizes case
            s1 = "dogoLong";
            s2 = "dogo";

            expected = false;

            actual = Questions.AreTwoStringsAnagrams2(s1, s2);

            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void ReplaceSpacesTest()
        {
            string s = " st li m ol";
            string expected = "%20st%20li%20m%20ol";

            string actual = Questions.ReplaceSpaces(s);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ReplaceSpaces2Test()
        {
            string s = " st li m ol";
            string expected = "%20st%20li%20m%20ol";

            string actual = Questions.ReplaceSpaces2(s);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Maximum69NumberTest()
        {
            int number = 969969;
            int expected = 999969;

            int actual = Questions.Maximum69Number(number);
            Assert.AreEqual(expected, actual);

            number = 99999;
            expected = 99999;

            actual = Questions.Maximum69Number(number);
            Assert.AreEqual(expected, actual);

            number = 66666;
            expected = 96666;

            actual = Questions.Maximum69Number(number);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IsSubStringTest()
        {
            string str1 = "waterbottle";
            string str2 = "erbottlewat";

            bool expected = true;

            bool actual = Questions.IsSubString(str1, str2);

            Assert.AreEqual(expected, actual);

            // 
            str1 = "waterbottle";
            str2 = "ertlewabott";

            expected = false;

            actual = Questions.IsSubString(str1, str2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SmallerNumbersThanCurrent()
        {
            int[] numbers = new int[] { 13, 6, 7, 8, 1 };
            int[] expected = new int[] { 4, 1, 2, 3, 0 };

            int[] actual = Questions.SmallerNumbersThanCurrent(numbers);
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PalindromePermutation()
        {
            string str = "tactcoa";
            bool expected = true;

            bool actual = Questions.PalindromePermutation(str);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringCompression()
        {
            string str = "aaabbcccd";
            string expected = "a3b2c3d1";

            string actual = Questions.StringCompression(str);

            Assert.AreEqual(expected, actual);
        }
    }
}
