using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Proveedor
    {
        public int ID { get; }
        public string Nombre { get; }
        public string Telefono { get; }
        public string Email { get; }
        public string Contacto { get; }
        public string Observaciones { get; }
        public bool Anulado { get; }

        public Proveedor(ProveedorDto dto)
        {
            ID = dto.ID;
            Telefono = dto.Telefono;
            Email = dto.Email;
            Contacto = dto.Contacto;
            Observaciones = dto.Observaciones;
            Anulado = dto.Anulado;
        }

        public ProveedorDto Dto()
        {
            ProveedorDto dto = new ProveedorDto();

            dto.ID = ID;
            dto.Nombre = Nombre;
            dto.Telefono = Telefono;
            dto.Email = Email;
            dto.Contacto = Contacto;
            dto.Observaciones = Observaciones;
            dto.Anulado = Anulado;
            
            return dto;
        }
    }
}