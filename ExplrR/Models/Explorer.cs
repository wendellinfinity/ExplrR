using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExplrR.Models {

    public class Coordinates {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Explorer {

        public string Name { get; set; }
        public string StatusMessage { get; set; }
        public Coordinates Location { get; set; }

    }
}