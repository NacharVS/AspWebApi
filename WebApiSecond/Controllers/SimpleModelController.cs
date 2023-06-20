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
           return Ok(DbExtensions.GetAllDocs());
        }

        [HttpGet("GetSingle")]
        public IActionResult GetFirstInList(string name)
        {
            var obj = DbExtensions.GetSingleModel(name);
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult SendModel(SimpleModel model)
        {
            DbExtensions.AddDocs(model);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateModel(string name, SimpleModel modelForUpdate)
        {
            DbExtensions.ReplaseDoc(name, modelForUpdate);
            return Ok();
        }

        [HttpPut("UpdateAge")]
        public IActionResult UpdateModel(string name, int age)
        {
            DbExtensions.UpdateDoc(name, age);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteModel(string name)
        {
            DbExtensions.DeleteDoc(name);
            return Ok();
        }

    }
}
