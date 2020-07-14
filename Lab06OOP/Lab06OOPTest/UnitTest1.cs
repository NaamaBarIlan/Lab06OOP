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
    }
}
