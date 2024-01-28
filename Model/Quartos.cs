using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class Quartos
    {
        [Key]
        public int QuartoId { get; set; }
        public int NumQuarto { get; set; }
        public int TipoQuartoId { get; set; }
        public TiposQuarto? TipoQuarto { get; set; }
        public int Adaptado { get; set; }
        public int statusQuartoId { get; set; }
        public StatusQuarto? statusQuarto { get; set; }
        public double ValorQuarto { get; set; }
        public int CapacidadeMaxima { get; set; }
        public int CapacidadeOpcional { get; set; }

        public Quartos()
        {

        }
        public Quartos(int NumeroQuarto, int tiposQuartoId, int Adaptado, int statusQuartoId, double valorQuarto, int CapacidadeMaxima, int CapacidadeOpcional)
        {
            this.NumQuarto = NumeroQuarto;
            this.TipoQuartoId = tiposQuartoId;
            this.Adaptado = Adaptado;
            this.statusQuartoId = statusQuartoId;
            this.ValorQuarto = valorQuarto;
            this.CapacidadeMaxima = CapacidadeMaxima;
            this.CapacidadeOpcional = CapacidadeOpcional;
        }
    }
}