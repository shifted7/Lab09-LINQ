using System;
using System.Collections.Generic;
using System.Text;

namespace LINQInManhattan.Classes
{
    class DataObject
    {
        public string Type { get; set; }
        public List<Feature> Features { get; set; }

    }

    public class Feature
    {
        public string Type { get; set; }
        public GeoObj Geometry { get; set; }
        public PropObj Properties { get; set; }
    }

    public class GeoObj
    {
        public string Type { get; set; }
        public int[] Coordinates { get; set; }

    }

    public class PropObj
    {
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Borough { get; set; }
        public string Neighborhood { get; set; }
        public string County { get; set; }
    }
}
