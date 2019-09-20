using System;

namespace Libreria.Models
{
    public class Venta
    {
        private DateTime fecha;
        private bool anulada;
        private float monto;

        public Venta(DateTime fecha)
        {
            this.fecha = fecha;
        }
    }
}