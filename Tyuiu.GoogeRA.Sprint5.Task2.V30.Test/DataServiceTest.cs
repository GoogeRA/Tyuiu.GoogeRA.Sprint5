using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GoogeRA.Sprint5.Task2.V30.Lib;


namespace Tyuiu.GoogeRA.Sprint5.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\rgoog\source\repos\Tyuiu.GoogeRA.Sprint5\Tyuiu.GoogeRA.Sprint5.Task2.V30\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
