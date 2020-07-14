using Lab06_OOP.classes;
using System;

namespace Lab06_OOP
{
    public class Program
    {/// <summary>
    /// The below method calls 5 subsequent methods (all from concrete derived objects)
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            LionTest();
            RamTest();
            OkapiTest();
            LizardTest();
            RattlesnakeTest();

        }
        /// <summary>
        /// The following method proves that CongoLion inherits info from base class Animal
        /// </summary>
        static void LionTest()
        {
            CongoLion lion = new CongoLion();
            int lionAge = lion.Age;
            Console.WriteLine(lionAge);
            
        }
        /// <summary>
        /// the following method proves that MarinaRam inherits info from the base class Animal
        /// </summary>
        static void RamTest()
        {
            MarinaRam ram = new MarinaRam();
            int ramAge = ram.Age;
            Console.WriteLine(ramAge);
        }
        /// <summary>
        /// the following method proves that Okapi inherits info from the base class Animal
        /// </summary>
        static void OkapiTest()
        {
            Okapi okapi = new Okapi();
            int okapiAge = okapi.Age;
            Console.WriteLine(okapiAge);
        }
        /// <summary>
        /// the following method proves that MonitorLizard inherits info from the base class Animal
        /// </summary>
        static void LizardTest()
        {
            MonitorLizard lizard = new MonitorLizard();
            int lizardAge = lizard.Age;
            Console.WriteLine(lizardAge);
        }
        /// <summary>
        /// the following method proves that Rattlesnake inherits info from the base class Animal
        /// </summary>
        static void RattlesnakeTest()
        {
            Rattlesnake snake = new Rattlesnake();
            int snakeAge = snake.Age;
            Console.WriteLine(snakeAge);
        }
    }
}
