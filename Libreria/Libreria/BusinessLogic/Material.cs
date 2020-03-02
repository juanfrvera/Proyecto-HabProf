using System.Collections.Generic;
using System.Linq;
using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Material
    {
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string Issn { get; set; }
        public string Ubicacion { get; set; }
        public short Edicion { get; set; }
        public short Stock { get; set; }
        public int ID { get; set; }
        public float Precio { get; set; }
        public bool Activo { get; set; }
        public bool Usado { get; set; }
        public Proveedor Proveedor { get; set; }
        public Editorial Editorial { get; set; }
        public Categoria Categoria { get; set; }
        public List<MaterialAutor> Autores { get; set; }

        // Constructor
        public Material(MaterialDto dto)
        {
            ID = dto.ID;
            Titulo = dto.Titulo;
            Isbn = dto.Isbn;
            Issn = dto.Issn;
            Ubicacion = dto.Ubicacion;
            Edicion = dto.Edicion;
            Stock = dto.Stock;
            Precio = dto.Precio;
            Activo = dto.Anulado;
            Usado = dto.Usado;
            Proveedor = new Proveedor(dto.Proveedor);
            Editorial = new Editorial(dto.Editorial);
            Categoria = new Categoria(dto.Categoria);
            Autores = new List<MaterialAutor>();
            
            foreach (AutorDto unAutorDto in dto.Autores)
            {
                Autores.Add(new MaterialAutor(this, new Autor(unAutorDto)));
            }
        }
        
        // Generar DTO
        public MaterialDto Dto()
        {
            MaterialDto dto = new MaterialDto();
            
            dto.ID = ID;
            dto.Titulo = Titulo;
            dto.Isbn = Isbn;
            dto.Issn = Issn;
            dto.Ubicacion = Ubicacion;
            dto.Edicion = Edicion;
            dto.Stock = Stock;
            dto.Precio = Precio;
            dto.Anulado = Activo;
            dto.Usado = Usado;
            dto.Proveedor = Proveedor.Dto();
            dto.Editorial = Editorial.Dto();
            dto.Categoria = Categoria.Dto();
            dto.Autores = new List<AutorDto>();

            foreach (Autor unAutor in Autores.Select(ma => ma.Autor))
            {
                dto.Autores.Add(unAutor.Dto());
            }
            
            return dto;
        }

        public void Anular()
        {
            Activo = false;
        }
    }
}