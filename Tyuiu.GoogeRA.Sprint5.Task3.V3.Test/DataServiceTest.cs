using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GoogeRA.Sprint5.Task3.V3.Lib;

namespace Tyuiu.GoogeRA.Sprint5.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\rgoog\source\repos\Tyuiu.GoogeRA.Sprint5\Tyuiu.GoogeRA.Sprint5.Task3.V3\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
