using System.Collections.Generic;
using System.Linq;
using Libreria.BusinessLogic;
using Libreria.BusinessLogic.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class Categorias : Controller, ICrud
    {
        private List<Categoria> _categorias;

        //TODO: agregar el DbContext al constructor
        public Categorias()
        {
            
        }
        
        // GET
        public List<CategoriaDto> Index(string filtro)
        {
            return Listar(filtro);
        }

        //TODO: agregar paginación al listar.
        public IList<DtoBase> Listar(string filtro)
        {
            return new List<DtoBase>();
        }

        public IList<CategoriaDto> Listar(string filtro)
        {
            return new List<CategoriaDto>();
        }

        public IActionResult Agregar(CategoriaDto unDto)
        {
            Categoria unaCategoria = new Categoria(unDto);
            _categorias.Append(unaCategoria);
        }

        public IActionResult Modificar(CategoriaDto unDto)
        {
            Categoria categoriaNueva = new Categoria(unDto);
            var encontrado = _categorias.IndexOf(unaCategoria);
            if (encontrado)
            {
                _categorias[encontrado] = categoriaNueva;
            }
            else
            {
                return Ok("Elemento no encontrado");
            }

            return Ok("Elemento actualizado");
        }

        public DtoBase Consultar(int id)
        {
            CategoriaDto dto = _categorias[id].Dto();
            return dto;
        }
    }
}