using System.ComponentModel.DataAnnotations;

namespace HotelApi.Model
{
    public class StatusQuarto
    {
        [Key]
        public int StatusQuartoId { get; set; }
        [StringLength(20)]
        public string? Descricao { get; set; }

        public StatusQuarto()
        {
            
        }

        public StatusQuarto(string Descricao)
        {
            this.Descricao = Descricao;
        }
    }
}