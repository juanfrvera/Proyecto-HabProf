using System.Collections.Generic;

namespace Libreria.BusinessLogic.Dto
{
    public class VentaDto
    {
        public bool anulada;
        public float monto;
        public string fecha;
        public int idMedioDePago;
        public ICollection<LineaDeVentaDto> lineasDeVenta;
    }
}