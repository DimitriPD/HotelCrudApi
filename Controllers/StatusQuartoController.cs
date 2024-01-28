using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("hotel/[controller]")]
    public class StatusQuartoController : Controller
    {
        [HttpGet]
        public IActionResult listarStatusQuarto()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.statusQuarto.ToList());
            }
        }

        [HttpPost]
        public void cargaInicial([FromBody] StatusQuarto novoStatus)
        {
            using (var _context = new HotelDBContext())
            {
                _context.statusQuarto.Add(novoStatus);
                _context.SaveChanges();
            }
        }

        [HttpPut]
        public IActionResult put([FromBody] StatusQuarto statusQuarto)
        {
            using (var _context = new HotelDBContext())
            {
                var statusQ = _context.statusQuarto.FirstOrDefault(sq => sq.StatusQuartoId == statusQuarto.StatusQuartoId);

                if (statusQ == null)
                {
                    return NotFound("Nao encontrado");
                }

                _context.Entry(statusQ).CurrentValues.SetValues(statusQuarto);
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete]
        public IActionResult delete(int idStatus)
        {
            using (var _context = new HotelDBContext())
            {
                var statusQ = _context.statusQuarto.FirstOrDefault(sq => sq.StatusQuartoId == idStatus);

                if (statusQ == null)
                {
                    return NotFound("Nao encontrado");
                }

                _context.statusQuarto.Remove(statusQ);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}