using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesExampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(ISingletonService singletonService1,
            ISingletonService singletonService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ITrasientService trasientService1,
            ITrasientService trasientService2) {

            return Ok(new { 
                singletonService1 = "Singleton service 1st instance guid = " + singletonService1.GetGuid(),
                singletonService2 = "Singleton service 2nd instance guid = " + singletonService2.GetGuid(),
                scopedService1 = "Scoped service 1st instance guid = " + scopedService1.GetGuid(),
                scopedService2 = "Scoped service 2nd instance guid = " + scopedService2.GetGuid(),
                trasientService1 = "Transient service 1st instance guid = " + trasientService1.GetGuid(),
                trasientService2 = "Transient service 2nd instance guid = " + trasientService2.GetGuid(),
            });
            
        }
    }
}
