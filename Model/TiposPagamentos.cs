using System.ComponentModel.DataAnnotations;

namespace HotelApi.Model
{
    public class TiposPagamentos
    {
        [Key]
        public int TipoPagamentoId { get; set; }
        [StringLength(20)]
        public string? Descricao { get; set; }

        public TiposPagamentos()
        {
            
        }

        public TiposPagamentos(string Descricao)
        {
            this.Descricao = Descricao;
        }
    }
}