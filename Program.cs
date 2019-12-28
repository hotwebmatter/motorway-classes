using System;
using static System.Console;

namespace motorway_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // test constructors
            Motorway aMotorway = new Motorway();
            Motorway bMotorway = new Motorway("Route 44", "Parkway", "W");
            Motorway cMotorway = new Motorway("A14", "dual carriageway", "ESE", "Highways Agency", 4);
            cMotorway.TollCharged = true;
            Motorway[] motorwayArray = { aMotorway, bMotorway, cMotorway };
            // test instance methods
            foreach (Motorway obj in motorwayArray)
            {
                WriteLine(obj.FullName());
                WriteLine(obj.HasToll());
                WriteLine(obj.HasLanes());
                WriteLine(obj.ToString());
            }
        }
    }
}
