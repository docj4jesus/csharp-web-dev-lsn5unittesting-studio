using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyStringIsTrue()
        {
            bool result = BalancedBrackets.HasBalancedBrackets("");
            Assert.AreEqual(result, true);
        }

        [TestMethod]

        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]

        public void NullStringIsFalse() //doesn't make much sense, may code it to show an error or message later
        {
            bool result = BalancedBrackets.HasBalancedBrackets(null);
            Assert.IsFalse(result);
        }

        [TestMethod]

        public void FullBalancedString()
        {
            string input = "[LaunchCode]";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, true);
        }

        [TestMethod]

        public void PartiallyWrappedBalancedStringReturnsTrue()
        {
            string input = "Launch[Code]";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, true);
        }

        [TestMethod]

        public void FullyWrappedUnbalancedStringReturnsFalse()
        {
            string input = "[LaunchCode";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, false);
        }

        [TestMethod]

        public void WrongNestedBracketReturnsFalse() //could also use IndexOf to figure out: (Colin's Code) else if (str.IndexOf('[') < str.IndexOf(']') && ch == ']'), can also do if brackets < 0

        {
            string input = "][";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.AreEqual(result, false);
        }

        [TestMethod]

        public void BracketsBeforeReturnsTrue()
        {
            string input = "[]LaunchCode";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.IsTrue(result);
        }

        [TestMethod]

        public void MisnestedMiddleBracketsIsFalse()
        {
            string input = "Launch]Code[";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.IsFalse(result);
        }

        [TestMethod]

        public void OpenBracketOnlyIsFalse()
        {
            string input = "[";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.IsFalse(result);
        }

        [TestMethod]

        public void ClosedBracketOnlyIsFalse()
        {
            string input = "]";
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.IsFalse(result);
        }

       /* public void StrIsNotTypeStringReturnsFalse()
        {
            int input = 43;
            bool result = BalancedBrackets.HasBalancedBrackets(input);
            Assert.IsFalse(result);
        }*/
    }
}
