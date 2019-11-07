using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class LineaDeVenta
    {
        public int Cantidad { get; }
        public float Precio { get; }
        public float Descuento { get; }
        public Material Material { get; }

        public LineaDeVenta(LineaDeVentaDto dto)
        {
            Cantidad = dto.cantidad;
            Precio = dto.precio;
            Descuento = dto.descuento;
            Material = new Material(dto.Material);
        }
    }
}