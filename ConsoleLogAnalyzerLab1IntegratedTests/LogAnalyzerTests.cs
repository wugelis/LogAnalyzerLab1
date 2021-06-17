using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLogAnalyzerLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ConsoleLogAnalyzerLab1.Tests
{
    [TestClass()]
    public class LogAnalyzerTests
    {
        [TestMethod()]
        public void Test_IsValidLogFileName()
        {
            Process p = new Process();
            string fileName 
                = Path.Combine(
                    @"D:\Gelis Documents\教育訓練課程\單元測試 UnitTest 與 Moq 物件實務課程\Samples\Lab1\SpecFlowLab1\ConsoleLogAnalyzerLab1\bin\Debug", 
                    "ConsoleLogAnalyzerLab1.exe");
            string arguments = "20200102.log";
            p.StartInfo = new ProcessStartInfo(fileName, arguments)
            { 
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true
            };

            p.Start();

            string result = p.StandardOutput.ReadToEnd();

            bool expected = true;
            bool actual = result.IndexOf("isValid=True") >= 0;

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}