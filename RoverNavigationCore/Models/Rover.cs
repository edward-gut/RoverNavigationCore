using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoverNavigationCore.Models
{
    public class Rover
    {
        public Orientation orientation { get; set; }
        public bool? valid { get; set; }
    }
}
