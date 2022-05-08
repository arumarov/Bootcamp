using NUnit.Framework;

namespace Day01Test
{
    public class Ex001Test
    {

        [Test]
        public void ClearStringTest01()
        {
            Assert.AreEqual("ваыиккамамвкм", Day01.Ex001.ClearString("ваыикка89мамвкм9"));
        }
        [Test]
        public void ClearStringTest02()
        {
            Assert.AreEqual("ваыиккамамвкм", Day01.Ex001.ClearString("ваыи34235кка89мамвкм9"));
        }
        [Test]
        public void ClearStringTest03()
        {
            Assert.AreEqual("ваыиккамамвкм", Day01.Ex001.ClearString("ва2344ыикка89мамвкм9"));
        }
    }
}