using Microsoft.EntityFrameworkCore;
using Cotizaciones.Models;

namespace Cotizaciones.Data {
    public class CotizacionesContext :DbContext{
        public CotizacionesContext(DbContextOptions<CotizacionesContext>options) : base(options){

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=cotizaciones.db");
        }

        public DbSet<Persona> Personas { get; set; }

    } 
}