using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OFXParser.Entities;

namespace OFXParser.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Extract extraxt = OFXParser.Parser.GetExtract("c:\\tempo\\exemplo02.ofx", new ParserSettings());
        }
    }
}
