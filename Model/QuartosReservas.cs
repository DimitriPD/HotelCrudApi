using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class QuartosReservas
    {
        public int ReservaId { get; set; }
        public Reservas? Reserva { get; set; }
        public int QuartoId { get; set; }
        public Quartos? Quarto { get; set; }

        public QuartosReservas()
        {
            
        }

        public QuartosReservas(int idReserva, int idQuarto)
        {
            this.ReservaId = idReserva;
            this.QuartoId = idQuarto;
        }
    }
}