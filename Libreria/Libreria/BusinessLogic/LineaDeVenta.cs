using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class LineaDeVenta
    {

        public int VentaId { get; set; }
        
        public Venta Venta { get; set; }

        public int Cantidad { get; set; }

        public float Precio { get; set; }
        public float Descuento { get; set; }

        public Material Material { get; set; }
        
        public LineaDeVenta(LineaDeVentaDto dto)
        {
            Cantidad = dto.Cantidad;
            Precio = dto.Precio;
            Descuento = dto.Descuento;
            Material = new Material(dto.Material);
        }
    }
}