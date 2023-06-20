using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSecond.Models;

namespace WebApiSecond.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VodaController : ControllerBase
    {
        private readonly VodaContext _context;
        public VodaController(VodaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetVoda()
        {
            return Ok(_context.Voda.ToList());
        }

        [HttpPost]
        public ActionResult CreateVoda(VodaModelDTO voda)
        {
            VodaModel model = new VodaModel();
            model.Count = voda.Count;
            model.VodaTypeModelId = voda.VodaTypeModelId;
            _context.Voda.Add(model);
            _context.SaveChanges();

            return Ok();
        }
    }
}
