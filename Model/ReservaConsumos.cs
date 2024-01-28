using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class ReservaConsumos
    {
        public int ReservaId { get; set; }
        public Reservas? Reserva { get; set; }
        public int ConsumoId { get; set; }
        public Consumos? Consumo { get; set; }
        public int Quantidade { get; set; }
    }
}