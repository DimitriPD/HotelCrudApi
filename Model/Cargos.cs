using System.ComponentModel.DataAnnotations;

namespace HotelApi.Model
{
    public class Cargos
    {
        [Key]
        public int CargoId { get; set; }
        [StringLength(20)]        
        public string? Descricao { get; set; }

        public Cargos()
        {
            
        }
        public Cargos(string descriacao)
        {
            this.Descricao = descriacao;
        }
    }
}