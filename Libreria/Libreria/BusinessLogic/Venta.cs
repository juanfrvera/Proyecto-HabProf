using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Venta
    {
        private int _id;
        private bool _activo;
        private float _monto;
        private string _timestamp;

        public int ID
        {
            get => _id;
        }

        public bool Activo
        {
            get => _activo;
        }

        public float Monto
        {
            get => _monto;
        }

        public string Timestamp
        {
            get => _timestamp;
        }

            public Venta(VentaDto dto)
        {
            _id = dto.ID;
            _activo = dto.Activo;
            _monto = dto.Monto;
            _timestamp = dto.Timestamp;
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
            _activo = false;
        }
    }
}