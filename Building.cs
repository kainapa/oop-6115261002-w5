using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_w5
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLat;
        private string buildingLong;
        public string BuildingCode
        {
            get { return buildingCode; }
            set { buildingCode = value; }
        }
        public string BuildingName
        {
            get { return buildingName; }
            set { buildingName = value; }
        }
        public string BuildingLat
        {
            get { return buildingLat; }
            set { buildingLat = value; }
        }
        public string BuildingLong
        {
            get { return buildingLong; }
            set { buildingLong = value; }
        }

        public Building() { }
        public Building(string bc, string bn, string blat, string blong)
        {
            this.BuildingCode = bc;
            this.BuildingName = bn;
            this.BuildingLat = blat;
            this.BuildingLong = blong;
        }

        public override string ToString()
        {
            return this.BuildingName + " ";
        }
    }
}
