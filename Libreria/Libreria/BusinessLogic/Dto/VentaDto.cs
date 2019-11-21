using System.Collections.Generic;

namespace Libreria.BusinessLogic.Dto
{
    public class VentaDto
    {
        public int ID { get; set; }
        public bool Activo { get; set; }
        public float Monto { get; set; }
        public string Timestamp { get; set; }
        public MedioDePagoDto MedioDePagoDto { get; set; }
    }
}