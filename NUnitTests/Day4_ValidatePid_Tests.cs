using NUnit.Framework;
using System.Collections.Generic;
using AdventOfCode2020;

namespace NUnitTests
{
    public class Day4_ValidatePid_Tests
    {
        Dictionary<string, string> dict1 = new Dictionary<string, string>();
        Dictionary<string, string> dict2 = new Dictionary<string, string>();

        [SetUp]
        public void Setup()
        {
            dict1.Clear();
            dict1.Add("pid", "000000001");

            dict2.Clear();
            dict2.Add("pid", "0123456789");
        }

        [Test]
        public void TestDict1()
        {
            bool isValid = Day04.ValidatePid(dict1);
            Assert.AreEqual(true, isValid);
        }

        [Test]
        public void TestDict2()
        {
            bool isValid = Day04.ValidatePid(dict2);
            Assert.AreEqual(false, isValid);
        }

    }
}