using NUnit.Framework;

namespace TechFabricSln.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Is_boughtBy_User_Return_Truyue()
        {
            var bought = new Class();

            var result = bought.BoughtBy(new User { customer = true });

            Assert.IsTrue(result);
        }
    }
}