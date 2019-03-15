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
            var file = @"C:\Users\marcelo\Downloads\ofx\EXTRATO_POR_PERIODO_010319_131842.ofx";

            Extract extraxt = OFXParser.Parser.GetExtract(file, new ParserSettings());
        }
    }
}
