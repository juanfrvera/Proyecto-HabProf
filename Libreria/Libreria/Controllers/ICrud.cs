using System.Collections.Generic;
using Libreria.BusinessLogic.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public interface ICrud
    {
        IList<DtoBase> Listar(string filtro);
        IActionResult Agregar(DtoBase unObjeto);
        IActionResult Modificar(DtoBase unObjeto);
        DtoBase Consultar(int id);
    }
}