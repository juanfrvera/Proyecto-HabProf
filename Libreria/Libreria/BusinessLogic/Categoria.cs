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

        public CategoriaDto Dto()
        {
            CategoriaDto dto = new CategoriaDto();
            
            dto.ID = ID;
            dto.Nombre = Nombre;
            dto.Anulado = Anulado;
            
            return dto;
        }
    }
}