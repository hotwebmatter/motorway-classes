using System;
using System.Collections.Generic;
using System.Text;

namespace motorway_classes
{
    class Motorway
    {
        // private data members
        private string highwayName,
                       streetType,
                       direction,
                       surface,
                       maintainedBy;
        private int numberOfLanes;
        private bool tollCharged;
        // public properties
        public string HighwayName
        {
            set
            {
                highwayName = value;
            }
            get
            {
                return highwayName;
            }
        }
        public string StreetType
        {
            set
            {
                streetType = value;
            }
            get
            {
                return streetType;
            }
        }
        public string Direction
        {
            set
            {
                direction = value;
            }
            get
            {
                return direction;
            }
        }
        public string Surface
        {
            set
            {
                surface = value;
            }
            get
            {
                return surface;
            }
        }
        public string MaintainedBy
        {
            set
            {
                maintainedBy = value;
            }
            get
            {
                return maintainedBy;
            }
        }
        public int NumberOfLanes
        {
            set
            {
                numberOfLanes = value;
            }
            get
            {
                return numberOfLanes;
            }
        }
        public bool TollCharged
        {
            set
            {
                tollCharged = value;
            }
            get
            {
                return tollCharged;
            }
        }
        // enough constructors to make class flexible
        public Motorway()
        {
            highwayName = "Route 66";
            streetType = "Interstate";
            direction = "SW";
            surface = "blacktop";
            maintainedBy = "USDOT";
            numberOfLanes = 4;
            tollCharged = false;
        }
        public Motorway(string name, string type, string dir)
        {
            highwayName = name;
            streetType = type;
            direction = dir;
            surface = "blacktop";
            maintainedBy = "USDOT";
            numberOfLanes = 4;
            tollCharged = false;
        }
        public Motorway(string name, string type, string dir, string maintainer, int lanes)
        {
            highwayName = name;
            streetType = type;
            direction = dir;
            surface = "blacktop";
            maintainedBy = maintainer;
            numberOfLanes = lanes;
            tollCharged = false;
        }
        // instance methods
        public string FullName()
        {
            return highwayName;
        }
        public string HasToll()
        {
            string result = String.Format("{0, 16}{1, 16}", "Highway name:", highwayName);
            if (tollCharged)
            {
                result += String.Format("\n{0, 16}{1, 16}", "Toll charged:", "TRUE");
            }
            else
            {
                result += String.Format("\n{0, 16}{1,16}", "Toll charged:", "FALSE");
            }
            return result;
        }
        public string HasLanes()
        {
            string result = String.Format("{0, 16}{1, 16}", "Highway name:", highwayName);
            result += String.Format("\n{0, 16}{1, 16}", "How Many Lanes:", numberOfLanes);
            return result;
        }
        // override ToString() method
        public override string ToString()
        {
            string result = String.Format("\n****** Motorway Instance Values ******\n");
            result += String.Format("* {0, 17}{1, 17} *\n", "Highway Name:", highwayName);
            result += String.Format("* {0, 17}{1, 17} *\n", "Type of Street:", streetType);
            result += String.Format("* {0, 17}{1, 17} *\n", "Direction:", direction);
            result += String.Format("* {0, 17}{1, 17} *\n", "Surface:", surface);
            result += String.Format("* {0, 17}{1, 17:N} *\n", "Number of Lanes:", numberOfLanes);
            result += String.Format("* {0, 17}{1, 17} *\n", "Toll Charged:", tollCharged);
            result += String.Format("* {0, 17}{1, 17} *\n", "Maintained By:", maintainedBy);
            result += String.Format("**************************************\n");
            return result;
        }
    }
}
