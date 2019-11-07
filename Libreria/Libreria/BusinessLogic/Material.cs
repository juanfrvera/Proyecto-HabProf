using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Material
    {
        private string titulo, isbn, issn, ubicacion;
        private short edicion, stock;
        private int id;
        private float precio;
        private bool anulado, usado;
        private Proveedor proveedor;
        private Editorial editorial;
        private Categoria categoria;
        private Autor autor;

        // Constructor
        public Material(MaterialDto dto)
        {
            id = dto.ID;
            titulo = dto.Titulo;
            isbn = dto.Isbn;
            issn = dto.Issn;
            ubicacion = dto.Ubicacion;
            edicion = dto.Edicion;
            stock = dto.Stock;
            precio = dto.Precio;
            anulado = dto.Anulado;
            usado = dto.Usado;
            proveedor = new Proveedor(dto.Proveedor);
            editorial = new Editorial(dto.Editorial);
            categoria = new Categoria(dto.Categoria);
            autor = new Autor(dto.Autor);
        }
        
        // Generar DTO
        public MaterialDto Dto()
        {
            MaterialDto dto = new MaterialDto();
            
            dto.ID = id;
            dto.Titulo = titulo;
            dto.Isbn = isbn;
            dto.Issn = issn;
            dto.Ubicacion = ubicacion;
            dto.Edicion = edicion;
            dto.Stock = stock;
            dto.Precio = precio;
            dto.Anulado = anulado;
            dto.Usado = usado;
            dto.Proveedor = proveedor.Dto();
            dto.Editorial = editorial.Dto();
            dto.Categoria = categoria.Dto();
            dto.Autor = autor.Dto();
            
            return dto;
        }

        public void Anular()
        {
            anulado = true;
        }

        public string Titulo { get; }
        public string Isbn { get; }
        public string Issn { get; }
        public string Ubicacion { get; }
        public short Edicion { get; }
        public short Stock { get; }
        public bool Anulado { get; }
        public bool Usado { get; }
        public float Precio { get; }
    }
}