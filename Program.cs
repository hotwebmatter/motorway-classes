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
            Motorway cMotorway = new Motorway("A14", "British Trunk Road", "ESE", "UK Highways Agency", 4);
            WriteLine("Hello World!");
        }
    }
}
