using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige_Common;

namespace Prestige.CommonTests
{
    [TestClass]
    public class NotificationServiceTests
    {
        [TestMethod]
        public void TestNotifyTalent()
        {
            //Arrange
            var expect = "Notifying talent: rey";
            // Act
            var actual = NotificationService.NotifyTalent("rey");
            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
