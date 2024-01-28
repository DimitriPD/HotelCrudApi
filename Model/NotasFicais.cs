using System.ComponentModel.DataAnnotations;

namespace HotelApi.Model
{
    public class NotasFicais
    {
        [Key]
        public int NotaId { get; set; }
        public int ReservaId { get; set; }
        public Reservas? Reserva { get; set; }
        public int TipoPagamentoId { get; set; }
        public TiposPagamentos? TipoPagamento { get; set; }
        public double Preco { get; set; }

        public NotasFicais()
        {

        }

        public NotasFicais(int reservaId, int tipoPagamentoId)
        {
            this.ReservaId = reservaId;
            this.TipoPagamentoId = tipoPagamentoId;
        }
    }
}