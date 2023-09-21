using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // This is a controller class. It's a class that handles HTTP requests
    // The ControllerBase class is a class that has all the functionality to handle HTTP requests
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        // This is a method that handles HTTP requests
        // These two methods respond to GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {

        }

        //GET api/command/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {

        }
    } 
}