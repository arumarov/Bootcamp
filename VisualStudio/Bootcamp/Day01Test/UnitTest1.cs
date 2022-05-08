using NUnit.Framework;

namespace Day01Test
{
    public class Ex001Test
    {

        [Test]
        public void ClearStringTest01()
        {
            Assert.AreEqual("�������������", Day01.Ex001.ClearString("�������89������9"));
        }
        [Test]
        public void ClearStringTest02()
        {
            Assert.AreEqual("�������������", Day01.Ex001.ClearString("����34235���89������9"));
        }
        [Test]
        public void ClearStringTest03()
        {
            Assert.AreEqual("�������������", Day01.Ex001.ClearString("��2344�����89������9"));
        }
    }
}