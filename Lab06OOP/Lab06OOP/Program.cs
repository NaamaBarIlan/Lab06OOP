using Lab06_OOP.classes;
using System;

namespace Lab06_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            LionTest();
            RamTest();
            OkapiTest();
            LizardTest();
            RattlesnakeTest();

        }
        /// <summary>
        /// The following method proves that lion inherits informatin from base class Animal and Mammal
        /// </summary>
        static void LionTest()
        {
            CongoLion lion = new CongoLion();
            int lionAge = lion.Age;
            Console.WriteLine(lionAge);
            
        }
        static void RamTest()
        {
            MarinaRam ram = new MarinaRam();
            int ramAge = ram.Age;
            Console.WriteLine(ramAge);
        }
        static void OkapiTest()
        {
            Okapi okapi = new Okapi();
            int okapiAge = okapi.Age;
            Console.WriteLine(okapiAge);
        }
        static void LizardTest()
        {
            MonitorLizard lizard = new MonitorLizard();
            int lizardAge = lizard.Age;
            Console.WriteLine(lizardAge);
        }
        static void RattlesnakeTest()
        {
            Rattlesnake snake = new Rattlesnake();
            int snakeAge = snake.Age;
            Console.WriteLine(snakeAge);
        }
    }
}
