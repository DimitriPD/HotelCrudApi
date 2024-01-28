using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HotelApi.Model
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [StringLength(55)]
        public string? NomeCliente { get; set; }
        [StringLength(40)]
        public string? Nacionalidade { get; set; }
        [StringLength(40)]
        public string? Email { get; set; }
        [StringLength(11)]
        public string? Telefone { get; set; }

        public Clientes()
        {
            
        }

        public Clientes(string nome, string nacionalidade, string email, string telefone)
        {
            this.NomeCliente = nome;
            this.Nacionalidade = nacionalidade;
            this.Email = email;
            this.Telefone = telefone;
        }
    }
}