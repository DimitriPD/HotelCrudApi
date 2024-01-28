using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("hotel/[controller]")]
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public IActionResult listarFuncionarios()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.funcionarios.ToList());
            }
        }

        [HttpGet("{cod}")]
        public IActionResult encontrarFuncionario(int cod)
        {
            using (var _context = new HotelDBContext())
            {
                var funcionario = _context.funcionarios.FirstOrDefault(f => f.CodFuncionario == cod);

                if (funcionario == null) 
                {
                    return NotFound("funcionario nao encontrado");
                }
                return Ok(funcionario);
            }
        }

        [HttpPost]
        public IActionResult cadastrarFuncionario([FromBody] Funcionarios novoFuncionario)
        {
            using (var _context = new HotelDBContext())
            {
                _context.funcionarios.Add(novoFuncionario);
                _context.SaveChanges();
                return Ok(novoFuncionario);
            }
        }

        [HttpPut]
        public IActionResult editarFuncionario([FromBody] Funcionarios editFuncionario)
        {
            using (var _context = new HotelDBContext())
            {
                var funcionario = _context.funcionarios.FirstOrDefault(f => f.CodFuncionario == editFuncionario.CodFuncionario);
                if (funcionario == null)
                {
                    return NotFound("Funcionario nao encontrado");
                }

                _context.Entry(funcionario).CurrentValues.SetValues(editFuncionario);
                _context.SaveChanges();
                return Ok("Funcionario editado com sucesso");
            }
        }

        [HttpDelete("{cod}")]
        public IActionResult deletarFuncionario(int cod)
        {
            using (var _context = new HotelDBContext())
            {
                var funcionario = _context.funcionarios.FirstOrDefault(f => f.CodFuncionario == cod);
                if (funcionario == null)
                {
                    return NotFound("Funcionario nao encontrado");
                }

                _context.funcionarios.Remove(funcionario);
                _context.SaveChanges();
                return Ok("Funcionario excluido com sucesso");
            }
        }
    }
}