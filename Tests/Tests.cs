using System;
using MiscLib;
using Xunit;

namespace Tests {
    public class MiscLibTests {

        // 1.  Method receives the two sides of a Rectangle and return the area

        [Theory]
        [InlineData (2, 1, 2)]
        [InlineData (20, 4, 5)]
        [InlineData (9, -3, -3)]
        [InlineData (-9, -3, 3)]

        public void CalcRectArea (int expected, int length, int width) {

            var test = new GroupOneFunctions ();
            Assert.Equal (expected, test.CalcRectArea (length, width));

        }

        // 2.  Checks if a number is a factorial	

        [Theory]
        [InlineData (1, true)]
        [InlineData (24, true)]
        [InlineData (5040, true)]
        [InlineData (99, false)]
        [InlineData (15511, false)]

        public void IsFactiorialNum (int number, bool result) {

            var test = new GroupOneFunctions ();
            Assert.Equal (result, test.IsFactiorialNum (number));

        }

        // // 3.  Coverts a temperature from Celcius to Farenheit, rounded up to the nearest whole number

        [Theory]
        [InlineData (40, 104)]
        [InlineData (20, 68)]
        [InlineData (0, 32)]
        [InlineData (-35, -31)]

        public void CelciusToFarenheit (int celcius, int result) {
            var test = new GroupOneFunctions ();
            Assert.Equal (result, test.CelciusToFarenheit (celcius));
        }

        // // 4.  Checks a string and returns true if it is palindromic

        [Theory]
        [InlineData ("glenelg", true)]
        [InlineData ("kayak", true)] // I removed capitalisation as it might have been too hard...
        [InlineData ("some men interpret nine memos", true)] //try remove spaces
        [InlineData ("This one's false", false)]

        public void IsPalindrome (string palindrome, bool result) {
            var test = new GroupOneFunctions ();
            Assert.Equal (result, test.IsPalindrome (palindrome));
        }

        // 5.  Replaces a character when found in a string

        [Theory]
        [InlineData ("Mississippi", "Mossossoppo", 'o', 'i')]
        [InlineData ("Replace Me", "Rxplacx Mx", 'x', 'e')] //space
        [InlineData ("i Love Fish and Chips", "u Love Fush and Chups", 'u', 'i')] //more spaces. I removed capitalisation as it might have been too hard...

        public void StringReplace_test (string expected, string original, char check, char replace) {
            GroupOneFunctions g1 = new GroupOneFunctions ();
            Assert.Equal (expected, g1.StringReplace (original, check, replace));
        }

        // // 6.  Counts the number of times a character occurs in a string

        [Theory]
        [InlineData ("mississippi", 'i', 4)]
        [InlineData ("australia", 'a', 3)]
        [InlineData ("hoot or toot?", 'o', 5)] //spaces

        public void CharCount_Test (string input, char character, int expected) {
            var test = new GroupOneFunctions ();
            Assert.Equal (expected, test.CharCount (input, character));
        }

    }
}