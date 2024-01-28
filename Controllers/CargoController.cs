using Azure;
using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("hotel/[controller]")]
    public class CargoController : Controller
    {
        [HttpGet]
        public IActionResult listarCargos()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.cargos.ToList());
            }
        }

        [HttpPost]
        public IActionResult criarCargo([FromBody] Cargos novoCargo)
        {
            using (var _context = new HotelDBContext())
            {
                _context.cargos.Add(novoCargo);
                _context.SaveChanges();
                return Ok(novoCargo);       
            }
        }

        [HttpPut]
        public IActionResult editarCargo([FromBody] Cargos editCargo)
        {
            using (var _context = new HotelDBContext())
            {
                var cargo  = _context.cargos.FirstOrDefault(c => c.CargoId == editCargo.CargoId);

                if (cargo == null)
                {
                    return NotFound("Cargo nao encontrado");
                }
                _context.Entry(cargo).CurrentValues.SetValues(editCargo);
                _context.SaveChanges();
                return Ok("Cargo editado");
            }
        }

        [HttpDelete]
        public IActionResult excluirCargo(int cargoId)
        {
            using ( var _context = new HotelDBContext())
            {
                var cargo = _context.cargos.FirstOrDefault(c => c.CargoId == cargoId);

                if (cargo == null)
                {
                    return NotFound("Não encontrado");
                }

                _context.cargos.Remove(cargo);
                _context.SaveChanges();
                return Ok("Cargo editado");
            }
        }
    }
}