
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleUwpApp.ViewModels;

namespace SampleUwpAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ボタンクリックイベントのテスト()
        {
            var printerStatus = new MainPageViewModel();

            // 初回のボタンクリックで"No Error"が表示される
            Assert.AreEqual(printerStatus.ButtonClick(), "No Error");


            // 2回目のボタンクリックで"DoorOpen"が表示される
            Assert.AreEqual(printerStatus.ButtonClick(), "DoorOpen");
        }
    }
}
