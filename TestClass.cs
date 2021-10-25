using NUnit.Framework;

namespace CodeWarsTest._7kyu
{
    //Your [TestFixture] should be placed here:
    [TestFixture]
    class Tests
    {
        [TestCase("18 15", 1)]
        [TestCase("43 23 40 13", 2)]
        [TestCase("33 8 16 47 30 30 46", 3)]
        [TestCase("6 24 6 8 28 8 23 47 17 29 37 18 40 49", 4)]
        public void BasicTests(string s, int expected)
        {
            var a = s.Split().Select(int.Parse).ToArray();
            Assert.That(Kata.Riders(a), Is.EqualTo(expected));
        }
    }