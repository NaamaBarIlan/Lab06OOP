using System;
using Xunit;
using Lab06_OOP.classes;

namespace Lab06OOPTest
{
    public class UnitTest1
    {/// <summary>
    /// below is a method that tests the inheritance of this class from its base classes
    /// </summary>
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
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
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
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void OkapiRunTest()
        {
            //Arrange
            Okapi okapi = new Okapi();
            string message = "Run";
            //Act
            string result = okapi.Run();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void OkapiPetTest()
        {
            //Arrange
            Okapi okapi = new Okapi();
            string message = "NAAAW PET THE CUTE OKAPI!!!";
            //Act
            string result = okapi.Pet();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>

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
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
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
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void CongoLionRoarTest()
        {
            //Arrange
            CongoLion lion = new CongoLion();
            string message = "Roar";
            //Act
            string result = lion.Roar();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void CongoLionHuntTest()
        {
            //Arrange
            CongoLion lion = new CongoLion();
            string message = "Hunting";
            //Act
            string result = lion.Hunt();
            //Assert
            Assert.Equal(message, result);
        }
        [Fact]
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
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
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void MarinaRamMilkTest()
        {
            //Arrange
            MarinaRam ram = new MarinaRam();
            string message = "Produce Milk";
            //Act
            string result = ram.ProduceMilk();
            //Assert
            Assert.Equal(message, result);
        }
        [Fact]
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        public void MarinaRamClimbTest()
        {
            //Arrange
            MarinaRam ram = new MarinaRam();
            int message = 12000;
            //Act
            int result = ram.Climb();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void MarinaRamRamTest()
        {
            //Arrange
            MarinaRam ram = new MarinaRam();
            string message = "Ram";
            //Act
            string result = ram.Ram();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>

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
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void MonitorLizardShedTest()
        {
            //Arrange
            MonitorLizard lizard = new MonitorLizard();
            string message = "It shed it's skin";
            //Act
            string result = lizard.Shed();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void MonitorLizardExtendTongueTest()
        {
            //Arrange
            MonitorLizard lizard = new MonitorLizard();
            int message = 10;
            //Act
            int result = lizard.ExtendTongue();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void MonitorLizardGrowTailTest()
        {
            //Arrange
            MonitorLizard lizard = new MonitorLizard();
            int message = 2;
            //Act
            int result = lizard.GrowTail();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>

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
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void RattlesnakeEggTest()
        {
            //Arrange
            Rattlesnake snake = new Rattlesnake();
            int output = 5;
            //Act
            int result = snake.LayEgg();
            //Assert
            Assert.Equal(output, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void RattlesnakeBiteTest()
        {
            //Arrange
            Rattlesnake snake = new Rattlesnake();
            string message = "Ow";
            //Act
            string result = snake.Bite();
            //Assert
            Assert.Equal(message, result);
        }
        /// <summary>
        /// below is a method that tests the inheritance of this class from its base classes
        /// </summary>
        [Fact]
        public void RattlesnakeRattleTest()
        {
            //Arrange
            Rattlesnake snake = new Rattlesnake();
            string message = "Rattle";
            //Act
            string result = snake.Rattle();
            //Assert
            Assert.Equal(message, result);
        }
    }
}
