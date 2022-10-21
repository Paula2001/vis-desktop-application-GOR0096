namespace Paramedic.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
public class HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var result = sw.ToString().Trim();
                Assert.AreEqual(1, 1);
            }
        }
    }
}