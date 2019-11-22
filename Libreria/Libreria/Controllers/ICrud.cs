using System.Collections.Generic;
using Libreria.BusinessLogic.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public interface ICrud
    {
        public List<DtoBase> Listar(string filtro);
        public IActionResult Agregar(DtoBase unObjeto);
        public IActionResult Modificar(DtoBase unObjeto);
        public DtoBase Consultar(int id);
    }
}