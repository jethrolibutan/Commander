using Microsoft.AspNetCore.Mvc;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Commander.Controllers
{

    // This is a controller class. It's a class that handles HTTP requests
    // The ControllerBase class is a class that has all the functionality to handle HTTP requests
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // This is a method that handles HTTP requests
        // These two methods respond to GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            // This is a variable that stores the commands from the repository
            var commandItems = _repository.GetAllCommands();

            // This returns those command items that came from the repository
            return Ok(commandItems);
        }

        //GET api/command/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            if(commandItem != null)
            {
                return Ok(commandItem);
            }
            return NotFound();
        }
    } 
}