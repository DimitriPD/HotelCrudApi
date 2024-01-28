using System.ComponentModel.DataAnnotations;

namespace HotelApi.Model
{
    public class Filiais
    {
        [Key]
        public int FilialId { get; set; }
        public string? NomeFilial { get; set; }
        public int QuartoId { get; set; }
        public Quartos? Quarto { get; set; }
        [StringLength(30)]
        public string? CidadeFilial { get; set; }
        [StringLength(30)]
        public string? RuaFilial { get; set; }
        [StringLength(05)]
        public string? NumeroFilial { get; set; }
        public int QuantEstrelas { get; set; }
    }
}