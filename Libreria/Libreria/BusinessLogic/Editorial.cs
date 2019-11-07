using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Editorial
    {
        public int id { get; }
        public string nombre { get; }
        public bool anulado { get; }

        public Editorial(EditorialDto dto)
        {
            id = dto.ID;
            nombre = dto.Nombre;
            anulado = dto.Anulado;
        }
    }
}