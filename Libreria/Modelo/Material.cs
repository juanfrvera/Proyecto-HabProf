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