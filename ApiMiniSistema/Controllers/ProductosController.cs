using ApiMiniSistema.DTOs;
using ApiMiniSistema.Entities;
using ApiMiniSistema.Utilities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMiniSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductosController(ApplicationDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("inventario")]
        public async Task<ActionResult> Inventario()
        {
            try
            {
                var productos = await context.Productos.ToListAsync();
                var productosDTO = mapper.Map<List<ProductosDTO>>(productos);
                return Ok(productosDTO);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("inventario{id}")]
        public async Task<ActionResult> InventarioPorId(int id)
        {
            try
            {
                var productos = await context.Productos.Where(x=> x.id == id).FirstOrDefaultAsync();
                var productosDTO = mapper.Map<ProductosDTO>(productos);
                return Ok(productosDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("movimiento")]
        public async Task<ActionResult> Movimiento([FromBody] CreacionProductosDTO productos)
        {
            try 
            {
                var producto = mapper.Map<Productos>(productos);
                context.Add(producto);
                await context.SaveChangesAsync();
                return Ok("Registro exitoso");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
    }
}
