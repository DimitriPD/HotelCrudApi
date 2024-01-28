using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("hotel/[controller]")]
    public class TiposPagamentoController : Controller
    {
        [HttpGet]
        public IActionResult listarTiposPagamento()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.tiposPagamentos.ToList());
            }
        }

        [HttpPost]
        public IActionResult criarTipoPagamento([FromBody] TiposPagamentos novoTipo)
        {
            using (var _context = new HotelDBContext())
            {
                _context.tiposPagamentos.Add(novoTipo);
                _context.SaveChanges();
                return Ok(novoTipo);       
            }
        }

        [HttpPut]
        public IActionResult editarTipoPagamento([FromBody] TiposPagamentos editTipo)
        {
            using (var _context = new HotelDBContext())
            {
                var tipoPagamento  = _context.tiposPagamentos.FirstOrDefault(t => t.TipoPagamentoId == editTipo.TipoPagamentoId);

                if (tipoPagamento == null)
                {
                    return NotFound("tipo pagamento nao encontrado");
                }
                _context.Entry(tipoPagamento).CurrentValues.SetValues(editTipo);
                _context.SaveChanges();
                return Ok("Tipo editado");
            }
        }

        [HttpDelete]
        public IActionResult excluirTipoPagamento(int idTipo)
        {
            using ( var _context = new HotelDBContext())
            {
                var tipo = _context.tiposPagamentos.FirstOrDefault(t => t.TipoPagamentoId == idTipo);

                if (tipo == null)
                {
                    return NotFound("Nao encontrado");
                }
                _context.tiposPagamentos.Remove(tipo);
                _context.SaveChanges();
                return Ok("Deletado com sucesso");
            }
        }
    }
}