using Microsoft.EntityFrameworkCore;

namespace Libreria.BusinessLogic
{
    public class LibreriaContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Material> Materiales { get; set; }
        public DbSet<MedioDePago> MediosDePagos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<LineaDeVenta> LineasDeVenta { get; set; }
    }
}