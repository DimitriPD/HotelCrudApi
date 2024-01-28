
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApi.Model
{
    public class Funcionarios
    {
        [Key]
        public int CodFuncionario { get; set; }
        [StringLength(50)]
        public string? NomeFuncionario { get; set; }
        public int CargoId { get; set; }
        public Cargos? Cargo { get; set; }

        public Funcionarios()
        {
            
        }

        public Funcionarios(string nome, int cargoId)
        {
            this.NomeFuncionario = nome;
            this.CargoId = cargoId;
        }
    }
}