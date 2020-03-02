using System.Collections.Generic;
using Libreria.BusinessLogic.Dto;

namespace Libreria.BusinessLogic
{
    public class Material
    {
        private string _titulo, _isbn, _issn, _ubicacion;
        private short _edicion, _stock;
        private int _id;
        private float _precio;
        private bool _anulado, _usado;
        private Proveedor _proveedor;
        private Editorial _editorial;
        private Categoria _categoria;
        private List<Autor> _autores;

        // Constructor
        public Material(MaterialDto dto)
        {
            _id = dto.ID;
            _titulo = dto.Titulo;
            _isbn = dto.Isbn;
            _issn = dto.Issn;
            _ubicacion = dto.Ubicacion;
            _edicion = dto.Edicion;
            _stock = dto.Stock;
            _precio = dto.Precio;
            _anulado = dto.Anulado;
            _usado = dto.Usado;
            _proveedor = new Proveedor(dto.Proveedor);
            _editorial = new Editorial(dto.Editorial);
            _categoria = new Categoria(dto.Categoria);
            _autores = new List<Autor>();
            
            foreach (AutorDto unAutorDto in dto.Autores)
            {
                _autores.Add(new Autor(unAutorDto));
            }
        }
        
        // Generar DTO
        public MaterialDto Dto()
        {
            MaterialDto dto = new MaterialDto();
            
            dto.ID = _id;
            dto.Titulo = _titulo;
            dto.Isbn = _isbn;
            dto.Issn = _issn;
            dto.Ubicacion = _ubicacion;
            dto.Edicion = _edicion;
            dto.Stock = _stock;
            dto.Precio = _precio;
            dto.Anulado = _anulado;
            dto.Usado = _usado;
            dto.Proveedor = _proveedor.Dto();
            dto.Editorial = _editorial.Dto();
            dto.Categoria = _categoria.Dto();
            dto.Autores = new List<AutorDto>();

            foreach (Autor unAutor in _autores)
            {
                dto.Autores.Add(unAutor.Dto());
            }
            
            return dto;
        }

        public void Anular()
        {
            _anulado = true;
        }

        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public string Isbn
        {
            get => _isbn;
            set => _isbn = value;
        }

        public string Issn
        {
            get => _issn;
            set => _issn = value;
        }

        public string Ubicacion
        {
            get => _ubicacion;
            set => _ubicacion = value;
        }

        public short Edicion
        {
            get => _edicion;
            set => _edicion = value;
        }

        public short Stock
        {
            get => _stock;
            set => _stock = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public float Precio
        {
            get => _precio;
            set => _precio = value;
        }

        public bool Anulado
        {
            get => _anulado;
            set => _anulado = value;
        }

        public bool Usado
        {
            get => _usado;
            set => _usado = value;
        }

        public Proveedor Proveedor
        {
            get => _proveedor;
            set => _proveedor = value;
        }

        public Editorial Editorial
        {
            get => _editorial;
            set => _editorial = value;
        }

        public Categoria Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }

        public List<Autor> Autores
        {
            get => _autores;
            set => _autores = value;
        }
    }
}