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
           return Ok(SimpleModel.GetModels());
        }
    }
}
