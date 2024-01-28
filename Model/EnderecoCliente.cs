using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class EnderecoCliente
    {
        [Key]
        public int ClienteId { get; set; }
        public Clientes? Cliente { get; set; }
        [StringLength(20)]
        public string? Cidade { get; set; }
        [StringLength(50)]
        public string? Rua { get; set; }
        [StringLength(5)]
        public string? Numero { get; set; }
    }
}