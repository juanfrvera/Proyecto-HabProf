using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Categoria
    {
        public int ID { get; }
        public string Nombre { get; }
        public bool Anulado { get; }

        public Categoria(CategoriaDto dto)
        {
            ID = dto.ID;
            Nombre = dto.Nombre;
            Anulado = dto.Anulado;
        }
    }
}