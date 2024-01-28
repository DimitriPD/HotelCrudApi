using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("[controller]")]
    public class TipoQuartoController : Controller
    {
        [HttpGet]
        public IActionResult get()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.tiposQuarto.ToList());
            }
        }

        [HttpPost]
        public IActionResult post([FromBody] TiposQuarto tiposQuarto)
        {
            using (var _context = new HotelDBContext())
            {
                _context.tiposQuarto.Add(tiposQuarto);
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult put([FromBody] TiposQuarto tiposQuarto)
        {
            using (var _context = new HotelDBContext())
            {
                var tipo = _context.tiposQuarto.FirstOrDefault(t => t.TipoQuartoId == tiposQuarto.TipoQuartoId);

                if (tipo == null)
                {
                    return NotFound("Nao encontrado");
                }

                _context.Entry(tipo).CurrentValues.SetValues(tiposQuarto);
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete]
                public IActionResult delete(int idTipo)
        {
            using (var _context = new HotelDBContext())
            {
                var tipo = _context.tiposQuarto.FirstOrDefault(t => t.TipoQuartoId == idTipo);

                if (tipo == null)
                {
                    return NotFound("Nao encontrado");
                }

                _context.tiposQuarto.Remove(tipo);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}