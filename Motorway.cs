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
    }
}
