using System.Collections.Generic;
using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Autor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Anulado { get; set; }
        public List<MaterialAutor> MaterialAutores { get; set; }

        public Autor(AutorDto dto)
        {
            ID = dto.ID;
            Nombre = dto.Nombre;
            Anulado = dto.Anulado;
        }

        public AutorDto Dto()
        {
            AutorDto dto = new AutorDto();
            
            dto.ID = ID;
            dto.Nombre = Nombre;
            dto.Anulado = Anulado;
            
            return dto;
        }
    }
}