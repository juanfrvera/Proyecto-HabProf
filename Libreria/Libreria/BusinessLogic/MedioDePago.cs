using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class MedioDePago
    {
        private int _id;
        private string _nombre;
        private float _comision;
        private bool _anulado;
        private TipoDeComision _tipoDeComision;

        public int ID
        {
            get => _id;
        }

        public string Nombre
        {
            get => _nombre;
        }

        public float Comision
        {
            get => _comision;
        }

        public bool Anulado
        {
            get => _anulado;
        }

        public TipoDeComision TipoDeComision
        {
            get => _tipoDeComision;
        }

        public MedioDePago(MedioDePagoDto dto)
        {
            _id = dto.ID;
            _nombre = dto.Nombre;
            _comision = dto.Comision;
            _anulado = dto.Anulado;
            _tipoDeComision = dto.TipoDeComision;
        }

        public MedioDePagoDto Dto()
        {
            MedioDePagoDto dto = new MedioDePagoDto();

            dto.Anulado = _anulado;
            dto.Comision = _comision;
            dto.Nombre = _nombre;
            dto.ID = _id;
            dto.TipoDeComision = _tipoDeComision;
            
            return dto;
        }
    }
}