using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("[controller]")]
    public class QuartoController : Controller
    {
        [HttpGet]
        public IActionResult get()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.quartos.ToList());
            }
        }

        [HttpPost]
        public IActionResult adicionarQuarto([FromBody] Quartos novoQuarto)
        {
            using (var _context = new HotelDBContext())
            {
                _context.quartos.Add(novoQuarto);
                _context.SaveChanges();
                return Ok(novoQuarto);
            }
        }

        [HttpPut]
        public IActionResult editarQuarto([FromBody] Quartos editQuarto)
        {
            using (var _context = new HotelDBContext())
            {
                var quarto = _context.quartos.FirstOrDefault(q => q.QuartoId == editQuarto.QuartoId);
                if (quarto == null)
                {
                    return NotFound("Quarto nao encontrado");
                }

                _context.Entry(quarto).CurrentValues.SetValues(editQuarto);
                _context.SaveChanges();
                return Ok("Quarto editado com sucesso");
            }
        }

        [HttpDelete]
        public IActionResult excluirQuarto(int idQuarto)
        {
            using (var _context = new HotelDBContext())
            {
                var quarto = _context.quartos.FirstOrDefault(q => q.QuartoId == idQuarto);
                if (quarto == null)
                {
                    return NotFound("Quarto nao encontrado");
                }
                _context.quartos.Remove(quarto);
                _context.SaveChanges();
                return Ok("Quarto excluido");
            }
        }
    }
}