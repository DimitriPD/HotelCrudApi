using System.ComponentModel.DataAnnotations;

namespace HotelApi.Model
{
    public class Servicos
    {
        [Key]
        public int ServicoId { get; set; }
        [StringLength(30)]
        public string? Descricao { get; set; }
        public double Preco { get; set; }
    }
}