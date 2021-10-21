using NUnit.Framework;

namespace CodeWarsTest._8kyu
{
    //Your [TestFixture] should be placed here:
    [TestFixture]
    public static class KataTests
    {

        [Test]
        public static void Tests()
        {
            Assert.AreEqual(Kata.total_goals, 58);
        }
    }
}