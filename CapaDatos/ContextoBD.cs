using CapaEntidades;
using System.Data.Entity;

namespace CapaDatos
{
    public class ContextoBD : DbContext
    {
        public ContextoBD()
            : base("name=ContextoBD")
        {
        }


        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }
    }
}
