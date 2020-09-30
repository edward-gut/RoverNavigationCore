using RoverNavigationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoverNavigationCore.Dto
{
    public class MovementDto
    {
        public Coordinate Cube { get; set; }
        public Orientation Position { get; set; }
        public string commands { get; set; }
    }
}
