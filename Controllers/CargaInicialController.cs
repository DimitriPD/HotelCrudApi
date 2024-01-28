using HotelApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("[controller]")]
    public class CargaInicialController : Controller
    {
        [HttpPost]
        public void cargasIniciais()
        {
            using (var _context = new HotelDBContext())
            {
                Clientes cl1 = new Clientes("Julio", "argentino", "julio@example.com", "999999999");
                Clientes cl2 = new Clientes("Antonio", "brasileiro", "antonio@example.com", "999999999");
                Clientes cl3 = new Clientes("Camila", "brasileira", "camila@example.com", "999999999");
                _context.clientes.AddRange(cl1,cl2,cl3);

                TiposPagamentos tp1 = new TiposPagamentos("Dinheito");
                TiposPagamentos tp2 = new TiposPagamentos("Debito");
                TiposPagamentos tp3 = new TiposPagamentos("Credito");
                TiposPagamentos tp4 = new TiposPagamentos("Pix");
                _context.tiposPagamentos.AddRange(tp1,tp2,tp3,tp4);
                
                TiposQuarto tq1 = new TiposQuarto("Solteiro");
                TiposQuarto tq2 = new TiposQuarto("Casal");
                TiposQuarto tq3 = new TiposQuarto("Familiar");
                TiposQuarto tq4 = new TiposQuarto("Presidencial");
                _context.tiposQuarto.AddRange(tq1, tq2, tq3, tq4);
                
                StatusQuarto sq1 = new StatusQuarto("Disponivel");
                StatusQuarto sq2 = new StatusQuarto("Ocupado");
                _context.statusQuarto.AddRange(sq1, sq2);

                Cargos c1 = new Cargos("Atendente");
                Cargos c2 = new Cargos("Gerente");
                Cargos c3 = new Cargos("Diretor");
                Cargos c4 = new Cargos("Lavanderia");
                Cargos c5 = new Cargos("Cozinha");
                Cargos c6 = new Cargos("Contabilidade");
                Cargos c7 = new Cargos("Faxina");
                _context.cargos.AddRange(c1,c2,c3,c4,c5,c6,c7);

                _context.SaveChanges();

                Funcionarios f1 = new Funcionarios("Pedro", 1);
                Funcionarios f2 = new Funcionarios("Julia", 1);
                Funcionarios f3 = new Funcionarios("Andre", 5);
                _context.funcionarios.AddRange(f1,f2,f3);

                Quartos q1 = new Quartos(101, 1, 0, 2, 100.00, 1, 0);
                Quartos q2 = new Quartos(102, 2, 1, 2, 200.00, 2, 0);
                Quartos q3 = new Quartos(103, 3, 0, 1, 300.00, 4, 0);
                Quartos q4 = new Quartos(104, 4, 1, 2, 400.00, 5, 0);
                _context.quartos.AddRange(q1, q2, q3, q4);

                _context.SaveChanges();

                Reservas r1 = new Reservas(new DateTime(2024,01,27), new DateTime(2024,01,30), 1, 1);
                Reservas r2 = new Reservas(new DateTime(2024,02,20), new DateTime(2024,02,26), 2, 2);
                Reservas r3 = new Reservas(new DateTime(2024,01,20), new DateTime(2024,01,25), 3, 2);
                _context.reservas.AddRange(r1,r2,r3);

                _context.SaveChanges();
            }
        }
    }
}