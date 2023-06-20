using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSecond.Models;

namespace WebApiSecond.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleModelController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllModels()
        {          
           return Ok();
        }

        //[HttpGet("/getModel")]
        //[Route("{name:string}")]
        //public IActionResult GetFirstInList([FromRoute]string name)
        //{
        //    return Ok();
        //}
        [HttpPost]
        public IActionResult SendModel(SimpleModel model)
        {
            return Ok();
        }
    }
}
