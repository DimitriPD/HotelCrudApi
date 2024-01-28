using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("hotel/[controller]")]
    public class ReservaController : Controller
    {
        [HttpGet]
        public IActionResult listarReservas()
        {
            using (var _context = new HotelDBContext())
            {
                return Ok(_context.reservas.ToList());
            }
        }

        [HttpGet("funcionarioReserva")]
        public IActionResult funcionarioReserva(int idReserva)
        {
            using (var _context = new HotelDBContext())
            {
                var reserva = _context.reservas.FirstOrDefault(r => r.ReservaId == idReserva);

                if (reserva == null)
                {
                    return NotFound("Reserva nao encontrada");
                }

                var funcionario = _context.funcionarios.FirstOrDefault(f => f.CodFuncionario == reserva.FuncionarioId);
                return Ok(funcionario.NomeFuncionario);
            }
        }

        [HttpPost]
        public IActionResult criarReserva(DateTime dtEntrada, DateTime dtSaida, int clienteId, int funcionarioId)
        {
            using (var _context = new HotelDBContext())
            {
                Reservas reserva = new Reservas( dtEntrada, dtSaida, clienteId, funcionarioId);
                _context.reservas.Add(reserva);
                _context.SaveChanges();
                return Ok(reserva);
            }
        }

        [HttpPost("addQuarto")]
        public IActionResult adicionarQuarto(int idQuarto, int idReserva, int capacidadeOpcional)
        {
            using (var _context = new HotelDBContext())
            {
                var quarto = _context.quartos.FirstOrDefault(q => q.QuartoId == idQuarto);
                if (quarto == null) {
                    return NotFound();
                }
                if (capacidadeOpcional == 1)
                {
                    quarto.CapacidadeOpcional = 1;
                    _context.Entry(quarto).CurrentValues.SetValues(quarto);
                }
                QuartosReservas quartosReserva = new QuartosReservas(idReserva, idQuarto);
                _context.quartosReservas.Add(quartosReserva);
                _context.SaveChanges();
                return Ok(quartosReserva);
            }
        }

        [HttpPut("cancelarReserva")]
        public IActionResult cancelarReserva(int idReserva)
        {
            using (var _context = new HotelDBContext())
            {
                var reserva = _context.reservas.FirstOrDefault(r => r.ReservaId == idReserva );

                if (reserva == null)
                {
                    return NotFound("Reserva nao encontrada");
                }

                DateTime diaHoje = DateTime.Today;
                reserva.DtCancelamento = diaHoje;
                _context.Entry(reserva).CurrentValues.SetValues(reserva);
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpPut("AlterarData")]
        public IActionResult AlterarDatas(int idReserva, DateTime DtEntrada, DateTime DtSaida)
        {
            using (var _context = new HotelDBContext())
            {
                var reserva = _context.reservas.FirstOrDefault(r => r.ReservaId == idReserva);
                if (reserva == null)
                {
                    return NotFound("Reserva nao encontrada");
                }

                reserva.DtEntrada = DtEntrada;
                reserva.DtSaida = DtSaida;
                _context.Entry(reserva).CurrentValues.SetValues(reserva);
                _context.SaveChanges();
                return Ok("Datas alteradas");
            }
        }

        [HttpDelete]
        public IActionResult deletarReserva(int idReserva )
        {
            using (var _context = new HotelDBContext())
            {
                var reserva = _context.reservas.FirstOrDefault(r => r.ReservaId == idReserva);
                if (reserva == null)
                {
                    return NotFound("Reserva nao encontrada");
                }

                _context.reservas.Remove(reserva);
                _context.SaveChanges();
                return Ok("Reserva excluida com sucesso");
            }
        }
    }
}