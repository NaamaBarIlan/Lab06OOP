using System;
using Xunit;
using Lab06_OOP.classes;

namespace Lab06OOPTest
{
    public class UnitTest1
    {
        [Fact]
        public void OkapiMakesMilkTest()
        {
            //Arrange
            Okapi okapi = new Okapi();
            string message = "Produce Milk";
            //Act
            string result = okapi.ProduceMilk();
            //Assert
            Assert.Equal(message, result);
        }

        [Fact]
        public void OkapiSleepTest()
        {
            //Arrange
            Okapi okapi = new Okapi();
            string message = "Time for Sleep";
            //Act
            string result = okapi.GetSleep();
            //Assert
            Assert.Equal(message, result);
        }

        [Fact]
        public void CongoLionAgeTest()
        {
            //Arrange
            CongoLion lion = new CongoLion();
            string message = "Time for Sleep";
            //Act
            string result = lion.GetSleep();
            //Assert
            Assert.Equal(message, result);
        }

        [Fact]
        public void CongoLionMilkTest()
        {
            //Arrange
            CongoLion lion = new CongoLion();
            string message = "Produce Milk";
            //Act
            string result = lion.ProduceMilk();
            //Assert
            Assert.Equal(message, result);
        }

        [Fact]
        public void MarinaRamFeedTest()
        {
            //Arrange
            MarinaRam ram = new MarinaRam();
            string message = "Time for Lunch";
            //Act
            string result = ram.GetFed();
            //Assert
            Assert.Equal(message, result);
        }

        [Fact]
        public void MonitorLizardFeedTest()
        {
            //Arrange
            MonitorLizard lizard = new MonitorLizard();
            string message = "Time for Lunch";
            //Act
            string result = lizard.GetFed();
            //Assert
            Assert.Equal(message, result);
        }

        [Fact]
        public void RattlesnakeSleepTest()
        {
            //Arrange
            Rattlesnake snake = new Rattlesnake();
            string message = "Time for Sleep";
            //Act
            string result = snake.GetSleep();
            //Assert
            Assert.Equal(message, result);
        }
    }
}
