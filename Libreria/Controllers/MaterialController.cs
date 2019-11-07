using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;

namespace Libreria.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MaterialController : ControllerBase
	{
		private readonly  MaterialContext _context;


		public MaterialController(MaterialContext context)
		{
			_context = context;
		}

		//Listar materiales
		//GET: /api/Material
		//Consultar un material
		//GET: /api/Material/5
		//
		[HttpGet]
		public async Task<ActionResult<Material>> GetMaterial(long id)
		{
			var unMaterial = await _context.Materiales.FindAsync(id);

			if (unMaterial == null) 
			{
				return NotFound();
			}
			return unMaterial;
		}

		//GET: /api/
		//Consultar materiales
		//POST: /api/Material
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Material>>> GetMateriales()
		{
			return await _context.Materiales.ToListAsync();
		}
				
		//Agregar un Material
		//POST: /api/Material
		[HttpPost]
		public async Task<ActionResult<Material>> PostMaterial(Material unMaterial)
		{
			_context.Materiales.Add(unMaterial);
			await _context.SaveChangesAsync();
			
			return CreatedAtAction(nameof(GetMaterial), new {}, unMaterial);
		}
	}

}
