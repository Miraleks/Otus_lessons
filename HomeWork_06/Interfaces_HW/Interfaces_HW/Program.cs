using System;
using System.Collections.Generic;
using System.Threading;

namespace Interfaces_HW
{
    class Program
    {
        static void Main(string[] args)
        {            
        }

        class Quadcopter : IFlyingRobot, IChargeable
        {
            List<string> _components = new () { "rotor1", "rotor2", "rotor3", "rotor4" };


            public void Charge()
            {
                Console.WriteLine("Charging...");
                Thread.Sleep(3000);
                Console.WriteLine("Charged!");
            }

            public List<string> GetComponents()
            {
                return _components;
            }

            string IChargeable.GetInfo()
            {

                Console.WriteLine("I'm Quadcopter, and I'm chargeable.") ;
                return "Chargeable";
            }

            string IRobot.GetInfo()
            {
                Console.WriteLine("I'm Quadcopter, and I'm chargeable and flying.");
                return "Quadcopter";
            }

        }

        interface IRobot
        {
            public string GetInfo();
            public List<string> GetComponents();
            public string GetRobotType() => "I am a simple robot.";
        }

        interface IChargeable
        {
            void Charge();
            string GetInfo();
        }

        interface IFlyingRobot : IRobot
        {
            public new string GetRobotType() => "I am a flying robot.";

        }


    }
}
