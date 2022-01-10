using FirstTest_Haiku;
using FirstTest_Haiku.App;
using FirstTest_Haiku.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest_HaikuTests
{
    [TestFixture]
    public class HaikuAppTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void HaikuChecker_With_Null_Test()
        {
            var expected = new Response
            {
                IsSuccess = false,
                Message = "Data empty"
            };

            Haiku haiku = new Haiku();

            var result= haiku.HaikuChecker(new List<string>());
            Assert.AreEqual(expected.IsSuccess, result.IsSuccess);
            Assert.AreEqual(expected.Message, result.Message);

        }



        [Test]
        public void ParseHaiku_With_Null_Test()
        {

            var expected = new HaikuParserResponse
            {
                IsSuccess = false,
                Message = "Data empty",
                Count = 0
            };

            HaikuParser haikuParser = new HaikuParser();

            var result = haikuParser.ParseHaiku("");
            Assert.AreEqual(expected.IsSuccess, result.IsSuccess);
            Assert.AreEqual(expected.Message, result.Message);
            Assert.AreEqual(expected.Count, result.Count);

        }
    }
}
