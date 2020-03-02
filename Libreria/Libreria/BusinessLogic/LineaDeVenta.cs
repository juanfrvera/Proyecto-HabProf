using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class LineaDeVenta
    {
        private int _cantidad;
        private float _precio;
        private float _descuento;
        private Material _material;
        
        public int VentaId { get; set; }
        
        public Venta Venta { get; set; }

        public int Cantidad
        {
            get => _cantidad;
        }

        public float Precio
        {
            get => _precio;
        }

        public float Descuento
        {
            get => _descuento;
        }

        public Material Material
        {
            get => _material;
        }
        
        public LineaDeVenta(LineaDeVentaDto dto)
        {
            _cantidad = dto.Cantidad;
            _precio = dto.Precio;
            _descuento = dto.Descuento;
            _material = new Material(dto.Material);
        }
    }
}