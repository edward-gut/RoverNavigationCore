using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoverNavigationCore.Dto;
using RoverNavigationCore.Models;
using RoverNavigationCore.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoverNavigationCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class movementController : ControllerBase
    {
        private readonly movementService movementService = new movementService();
   
        // POST api/<movementController>
        [HttpPost]
        public string Post(MovementDto movement)
        {
            try
            {

                Rover rover = movementService.move(movement.Cube, movement.Position, movement.commands);
                return rover.valid + " " + rover.orientation.pole + " Coordinates: (" + rover.orientation.x + ", " + rover.orientation.y + ")";
            }
            catch(Exception e)
            {
                return "Error: "+e.StackTrace;
            }

        }

    }
}
