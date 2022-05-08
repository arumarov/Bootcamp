using NUnit.Framework;

namespace Day01Test
{
    class Ex002Test
    {
        [Test]
        public void SumTest01()
        {
            Assert.AreEqual(4, Day01.Ex002.Sum(1,3));
        }

        [Test]
        public void SumTest02()
        {
            Assert.AreEqual(2, Day01.Ex002.Sum(-1, 3));
        }
    }
}