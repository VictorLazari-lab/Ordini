

using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProdottiController : ControllerBase
    {
        private readonly OrdiniContext _context;
        public ProdottiController(OrdiniContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Prodotto>>> GetProdotti()
        {
            var prodotti = await _context.Prodotti.ToListAsync();
            return Ok(prodotti);
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Prodotto>> GetProdotti(int id)
        {
            return await _context.Prodotti.FindAsync(id);
        }

    }
}