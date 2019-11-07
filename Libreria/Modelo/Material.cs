using System;

public class Material
{
		private string titulo;
		public string Titulo
		{
				get => titulo;
		}
		private string autores;
		private string isbn;
		private short edicion;
		private string issn;
		private string categoria;
		private string ubicacion;
		private float precio;
		private int stock;
		private bool anulado;
		private string id;

		public string Titulo1 => titulo;

		public string Ubicacion
		{
			get => ubicacion;
			set => ubicacion = value;
		}

		public float Precio
		{
			get => precio;
			set => precio = value;
		}

		public int Stock
		{
			get => stock;
			set => stock = value;
		}

		public bool Anulado
		{
			get => anulado;
			set => anulado = value;
		}

		public string Autores => autores;

		public string Isbn => isbn;

		public short Edicion => edicion;

		public string Issn => issn;

		public string Categoria => categoria;

		public string Id => id;

		public bool Usado => usado;

		private bool usado;
		public Material(string titulo)
		{
				this.titulo = titulo;
				this.stock = 0;
		}
		public void AgregarStock(int cantidad)
		{
				if (cantidad < 0)
						throw new Exception("Se trató de sumar una cantidad negativa");
				else
						stock = stock + cantidad;
		}
		public void QuitarStock(int cantidad)
		{
				if (cantidad > stock)
						throw new Exception("Stock insuficiente");
				else
						stock = stock - cantidad;
		}
		public void Anular()
		{
				anulado = true;
		}
		public void CambiarUbicacion(string nuevaUbicacion)
		{
				this.ubicacion = nuevaUbicacion;
		}
}