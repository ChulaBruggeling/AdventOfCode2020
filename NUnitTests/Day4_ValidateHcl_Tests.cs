using NUnit.Framework;
using System.Collections.Generic;
using AdventOfCode2020;

namespace NUnitTests
{
    public class Day4_ValidateHcl_Tests
    {
        Dictionary<string, string> dict1 = new Dictionary<string, string>();
        Dictionary<string, string> dict2 = new Dictionary<string, string>();
        Dictionary<string, string> dict3 = new Dictionary<string, string>();

        [SetUp]
        public void Setup()
        {
            dict1.Clear();
            dict1.Add("hcl", "#123abc");

            dict2.Clear();
            dict2.Add("hcl", "#123abz");

            dict3.Clear();
            dict3.Add("hcl", "123abc");
        }

        [Test]
        public void TestDict1()
        {
            bool isValid = Day04.ValidateHcl(dict1);
            Assert.AreEqual(true, isValid);
        }

        [Test]
        public void TestDict2()
        {
            bool isValid = Day04.ValidateHcl(dict2);
            Assert.AreEqual(false, isValid);
        }

        [Test]
        public void TestDict3()
        {
            bool isValid = Day04.ValidateHcl(dict3);
            Assert.AreEqual(false, isValid);
        }
    }
}