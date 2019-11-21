using System.Collections.Generic;

namespace Libreria.BusinessLogic.Dto
{
    public class DetalleVentaDto : VentaDto
    {
        public IList<LineaDeVentaDto> LineasDeVenta { get; set; }
    }
}