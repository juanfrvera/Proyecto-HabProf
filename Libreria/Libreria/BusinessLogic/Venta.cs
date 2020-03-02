using System.Collections.Generic;
using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Venta
    {
        public List<LineaDeVenta> Ventas { get; set; }

        public int ID { get; set; }

        public bool Activo { get; set; }

        public float Monto { get; set; }

        public string Timestamp { get; set; }

        public Venta(VentaDto dto)
        {
            ID = dto.ID;
            Activo = dto.Activo;
            Monto = dto.Monto;
            Timestamp = dto.Timestamp;
        }

        public VentaDto Dto()
        {
            VentaDto dto = new VentaDto();

            dto.ID = ID;
            dto.Activo = Activo;
            dto.Monto = Monto;
            dto.Timestamp = Timestamp;

            return dto;
        }

        public void Anular()
        {
            Activo = false;
        }
    }
}