using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class Reservas
    {
        [Key]
        public int ReservaId { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtSaida { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public int ClienteId { get; set; }
        public Clientes? Cliente { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionarios? Funcionario { get; set; }
        public double ValorDiaria {get; set;}

        public Reservas()
        {
            
        }

        public Reservas(DateTime dtEntrada, DateTime dtSaida, int clienteId, int funcionarioId)
        {
            this.DtEntrada = dtEntrada;
            this.DtSaida = dtSaida;
            this.ClienteId = clienteId;
            this.FuncionarioId = funcionarioId;
        }
    }
}