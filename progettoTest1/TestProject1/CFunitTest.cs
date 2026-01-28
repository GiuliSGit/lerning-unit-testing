using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using progettoTest1.services;

namespace TestProject1
{
    public class CFunitTest
    {
        private CFservice cFservice;
        [OneTimeSetUp]
            public void OneTimeSetup()
        {
            cFservice = new CFservice();
        }
        [TestCase("a", true)]
        [TestCase("b", false)]
        [TestCase("e", true)]
        [TestCase("i", true)]
        [TestCase("o", true)]
        [TestCase("u", true)]
        [TestCase("A", true)]
        [TestCase("U", true)]
        [TestCase("&", false)]
        [TestCase("2", false)]

        public void tdd(char var1, bool var2)
        {
            Assert.That(var2, Is.EqualTo(cFservice.sevocale(var1)));
        }
    }
}
