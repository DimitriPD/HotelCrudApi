using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace HotelApi.Model
{
    public class TiposQuarto
    {
        [Key]
        public int TipoQuartoId { get; set; }  
        public string? Descricao { get; set; }

        public TiposQuarto()
        {
            
        }

        public TiposQuarto(string Descricao)
        {
            this.Descricao = Descricao;
        }
    }
}