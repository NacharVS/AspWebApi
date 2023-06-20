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

        [HttpGet("GetSingle")]
        public IActionResult GetFirstInList(string name)
        {
            var obj = SimpleModel.GetModels().Find(x => x.Name == name);
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult SendModel(SimpleModel model)
        {
            return Ok();
        }
    }
}
