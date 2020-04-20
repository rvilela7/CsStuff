using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            // Arrange
            var currentActor = new Actor();
            var expected = "Actor";
            // Act
            string result = currentActor.GetOccupation();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            //Arrange
            var currentActor = new Actor("Rute Sousa");
            var expected = "Rute Sousa";
            //Act
            string result = currentActor.ActorName;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActor()
        {
            //Arrange
            string details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("João Silva");
            var expected = $"Actor João Silva is booked. {details}";
            //Act
            string result = currentActor.BookActor();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActorOnSpecificDate()
        {
            //Arrange
            string details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("João Silva");
            var testDate = DateTime.Today.ToShortDateString();
            var expected = $"Actor João Silva is booked on {testDate}. {details}";
            //Act
            string result = currentActor.BookActor(testDate);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFormatingOnSetterForBookActor()
        {
            //Arrange
            string details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("João Silva    ");
            var expected = $"Actor João Silva is booked. {details}";
            //Act
            string result = currentActor.BookActor();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            // Arrange
            var currentActor = new Actor { ActorName = "Miguel Sousa" };
            var expected = "Regular actor";
            // Act
            string result = currentActor.ActorDescription;
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropInitActorAge()
        {
            // Arrange
            var currentActor = new Actor { ActorName = "Bruno Ruivo", ActorAge = 46 };
            var expected = 46;
            // Act
            int result = currentActor.ActorAge;
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
