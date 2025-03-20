using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMiniSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProductosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // GET: api/<ProductosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {

            return Ok();
        }

        // POST api/<ProductosController>
        [HttpPost("movimiento")]
        public void Movimiento([FromBody] string value)
        {
        }

       
    }
}
