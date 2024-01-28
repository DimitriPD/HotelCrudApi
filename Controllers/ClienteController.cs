using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("hotel/[controller]")]
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult listarClientes()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.clientes.ToList());
            }
        }

        [HttpGet("{clienteId}")]
        public IActionResult encontrarCliente(int clienteId)
        {
            using (var _context = new HotelDBContext())
            {
                var cliente = _context.clientes.FirstOrDefault(c => c.ClienteId == clienteId);

                if (cliente == null) 
                {
                    return NotFound("Cliente nao encontrado");
                }
                return Ok(cliente);
            }
        }

        [HttpPost]
        public IActionResult cadastrarCliente([FromBody] Clientes novoCliente)
        {
            using (var _context = new HotelDBContext())
            {
                _context.clientes.Add(novoCliente);
                _context.SaveChanges();
                return Ok(novoCliente);
            }
        }

        [HttpPut]
        public IActionResult editarCliente(int cod, [FromBody] Clientes editCliente)
        {
            using (var _context = new HotelDBContext())
            {
                var cliente = _context.clientes.FirstOrDefault(c => c.ClienteId == editCliente.ClienteId);
                if (cliente == null)
                {
                    return NotFound("Cliente nao encontrado");
                }

                _context.Entry(cliente).CurrentValues.SetValues(editCliente);
                _context.SaveChanges();
                return Ok("Cliente editado com sucesso");
            }
        }

        [HttpDelete("{clienteId}")]
        public IActionResult deletarCliente(int clienteId)
        {
            using (var _context = new HotelDBContext())
            {
                var cliente = _context.clientes.FirstOrDefault(c => c.ClienteId == clienteId);
                if (cliente == null)
                {
                    return NotFound("Cliente nao encontrado");
                }

                _context.clientes.Remove(cliente);
                _context.SaveChanges();
                return Ok("Cliente excluido com sucesso");
            }
        }
    }

    
}