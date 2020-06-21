
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleUwpApp.Models;
using SampleUwpApp.ViewModels;

namespace SampleUwpAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ボタンクリックイベントのテスト()
        {
            var printerStatus = new MainPageViewModel(new MockPrinterStatus());

            // 初回のボタンクリックで"No Error"が表示される
            printerStatus.ButtonClick();
            Assert.AreEqual(printerStatus.ErrorMsg, "Error Info = No Error");


            // 2回目のボタンクリックで"DoorOpen"が表示される
            printerStatus.ButtonClick();
            Assert.AreEqual(printerStatus.ErrorMsg, "Error Info = DoorOpen");
        }
    }

    public class MockPrinterStatus : IPrinterStatus
    {
        public string GetErrorMsg(int count)
        {
            return "No Error";
        }
    }
}
