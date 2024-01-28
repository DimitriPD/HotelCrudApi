using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("[controller]")]
    public class NotaFiscalController : Controller
    {
        [HttpGet]
        public IActionResult listarNotasFiscais()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.notasFicais.ToList());
            }
        }

        [HttpPost]
        public IActionResult criarNotaFiscal(int reservaId, int tipoPagamento)
        {
            using (var _context = new HotelDBContext())
            {
                NotasFicais notaFiscal = new NotasFicais(reservaId, tipoPagamento);
                var reserva = _context.reservas.FirstOrDefault(r => r.ReservaId == reservaId);
                var totalDias = (reserva.DtSaida - reserva.DtEntrada).TotalDays;

                var quartosReservas = _context.quartosReservas.ToList();

                List<int> listQuartosId = new List<int>();
                foreach (var item in quartosReservas)
                {
                    if (item.ReservaId == reservaId)
                    {
                        listQuartosId.Add(item.QuartoId);
                    }
                }

                if (listQuartosId.Count == 0)
                {
                    return BadRequest();
                }

                foreach (var idQuarto in listQuartosId)
                {
                    var quarto = _context.quartos.FirstOrDefault(q => q.QuartoId == idQuarto);
                    if (quarto.CapacidadeOpcional > 0)
                    {
                        notaFiscal.Preco += quarto.ValorQuarto * 1.25 * totalDias;
                    }
                    else
                    {
                        notaFiscal.Preco += quarto.ValorQuarto * totalDias;
                    }
                }
                _context.notasFicais.Add(notaFiscal);
                _context.SaveChanges();
                return Ok(notaFiscal);
                
            }
        }
    }
}