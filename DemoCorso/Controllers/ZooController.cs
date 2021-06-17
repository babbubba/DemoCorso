using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCorso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZooController : ControllerBase
    {
        private readonly AnimalsService animalsService;

        public ZooController(AnimalsService animalsService)
        {
            this.animalsService = animalsService;
        }

        [HttpGet]
        public IActionResult GetAnimalsInJson()
        {
            var result = animalsService.GetAnimals();
            return Ok(result);
        }
    }
}
