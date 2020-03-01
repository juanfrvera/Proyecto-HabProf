using System.Collections.Generic;
using System.Linq;
using Libreria.BusinessLogic;
using Libreria.BusinessLogic.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class Categorias : Controller
    {
        private List<Categoria> _categorias;

        //TODO: agregar el DbContext al constructor
        public Categorias()
        {
            
        }
        
        // GET
        public List<CategoriaDto> Index(string filtro, int inicio, int fin)
        {
            return Listar(filtro, inicio, fin);
        }

        public List<CategoriaDto> Listar(string filtro, int inicio, int fin)
        {
            List<Categoria> listadoDeCategorias = _categorias.GetRange(inicio, fin);
            List<CategoriaDto> listadoDeCategoriasDto = new List<CategoriaDto>();

            foreach (Categoria categoria in listadoDeCategorias)
            {
                listadoDeCategoriasDto.Append(listadoDeCategorias.Dto());
            }
            
            return listadoDeCategoriasDto;
        }

        public IActionResult Agregar(CategoriaDto unDto)
        {
            Categoria unaCategoria = new Categoria(unDto);
            _categorias.Append(unaCategoria);

            return Ok();
        }

        public IActionResult Modificar(CategoriaDto unDto)
        {
            Categoria categoriaNueva = new Categoria(unDto);
            var encontrado = _categorias.IndexOf(categoriaNueva);
            if (encontrado >= 0)
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