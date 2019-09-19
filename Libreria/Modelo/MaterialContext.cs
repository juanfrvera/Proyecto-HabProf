using Microsoft.EntityFrameworkCore;

namespace Libreria.Models
{
	public class MaterialContext : DbContext
	{
		public MaterialContext(DbContextOptions<MaterialContext> options) : base(options)
		{
		}

		public DbSet<Material> Materiales { get; set; }
	}
}
