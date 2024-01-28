using System.ComponentModel.DataAnnotations;

namespace HotelApi.Model
{
    public class Consumos
    {
        [Key]
        public int ConsumoId { get; set; }
        [StringLength(20)]
        public string? Descricao { get; set; }
        public double Preco { get; set; }
        public int EntregueQuarto { get; set; }
    }
}