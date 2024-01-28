using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HotelApi.Model
{
    public class HotelDBContext : DbContext
    {
        public DbSet<Clientes> clientes {get; set;} = null!;
        public DbSet<EnderecoCliente> enderecoCliente {get; set;} = null!;
        public DbSet<Cargos> cargos {get; set;} = null!;
        public DbSet<Funcionarios> funcionarios {get; set;} = null!;
        public DbSet<TiposPagamentos> tiposPagamentos {get; set;} = null!;
        public DbSet<StatusQuarto> statusQuarto {get; set;} = null!;
        public DbSet<NotasFicais> notasFicais {get; set;} = null!;
        public DbSet<TiposQuarto> tiposQuarto {get; set;} = null!;
        public DbSet<Quartos> quartos {get; set;} = null!;
        public DbSet<Reservas> reservas {get; set;} = null!;
        public DbSet<QuartosReservas> quartosReservas {get; set;} = null!;
        public DbSet<Filiais> filiais {get; set;} = null!;
        public DbSet<Consumos> consumos {get; set;} = null!;
        public DbSet<ReservaConsumos> reservaConsumos {get; set;} = null!;
        public DbSet<Servicos> servicos {get; set;} = null!;
        public DbSet<ReservaServicos> reservaServicos {get; set;} = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuartosReservas>()
                .HasKey( x => new {x.ReservaId, x.QuartoId});
            
            modelBuilder.Entity<ReservaConsumos>()
                .HasKey( x => new {x.ReservaId, x.ConsumoId} );

            modelBuilder.Entity<ReservaServicos>()
                .HasKey( x => new {x.ReservaId, x.ServicoId} );
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=HotelApi;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}