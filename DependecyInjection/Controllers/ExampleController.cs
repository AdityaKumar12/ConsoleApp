using DependencyInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        IMessageService _messageService;
        public ExampleController(IMessageService messageService)
        {
            _messageService = messageService;            
        }

        [HttpGet]
        public IActionResult GetFromConstructor()
        {
            return Ok(_messageService.PrintMessage());
        }

        [HttpGet]
        public IActionResult GetFromProperty([FromServices] IMessageService messageService)
        {
            return Ok(messageService.PrintMessage());
        }
    }
}
