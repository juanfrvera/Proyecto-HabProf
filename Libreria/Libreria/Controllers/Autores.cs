using System.Collections.Generic;
using Libreria.BusinessLogic;
using Libreria.BusinessLogic.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Libreria.Controllers
{
    // TODO: implementar métodos de controlador Autores.
    [ApiController]
    [Route("[controller]")]
    public class Autores : Controller,ICrud<AutorDto>
    {
        [HttpPut]
        public IActionResult Agregar(AutorDto unObjeto)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut]
        public IActionResult Modificar(AutorDto unObjeto)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet("autores/{filtro}")]
        public List<AutorDto> Listar(string filtro)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet("autores/{unId}")]
        public AutorDto Consultar(int unId)
        {
            throw new System.NotImplementedException();
        }
    }
}