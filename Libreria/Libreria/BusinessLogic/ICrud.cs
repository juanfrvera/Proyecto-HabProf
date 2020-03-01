using System.Collections.Generic;
using System.ComponentModel;
using Libreria.BusinessLogic.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.BusinessLogic
{
    public interface ICrud<T> where T : DtoBase
    {
        List<T> Listar(string filtro);
        IActionResult Agregar(T unObjeto);
        IActionResult Modificar(T unObjeto);
        T Consultar(int unId);
    }
}