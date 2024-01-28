using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class ReservaServicos
    {
        public int ReservaId { get; set; }
        public Reservas? Reserva { get; set; }
        public int ServicoId { get; set; }
        public Servicos? Servico { get; set; }
        public int Quantidade { get; set; }
    }
}