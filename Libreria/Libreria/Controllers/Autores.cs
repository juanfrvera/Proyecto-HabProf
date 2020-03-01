using System.Collections.Generic;
using Libreria.BusinessLogic;
using Libreria.BusinessLogic.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    // TODO: implementar métodos de controlador Autores.
    public class Autores : Controller,ICrud<AutorDto>
    {
        // GET
        public IActionResult Agregar(AutorDto unObjeto)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Modificar(AutorDto unObjeto)
        {
            throw new System.NotImplementedException();
        }

        public List<AutorDto> Listar(string filtro)
        {
            throw new System.NotImplementedException();
        }

        public AutorDto Consultar(int unId)
        {
            throw new System.NotImplementedException();
        }
    }
}