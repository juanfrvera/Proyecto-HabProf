using System.Collections.Generic;

namespace Libreria.BusinessLogic.Dto
{
    public class MaterialDto : DtoBase
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string Issn { get; set; }
        public string Ubicacion { get; set; }
        public short Edicion { get; set; }
        public short Stock { get; set; }
        public bool Anulado { get; set; }
        public bool Usado { get; set; }
        public float Precio { get; set; }
        public List<AutorDto> Autores { get; set; }
        public EditorialDto Editorial { get; set; }
        public CategoriaDto Categoria { get; set; }
        public ProveedorDto Proveedor { get; set; }
    }
}