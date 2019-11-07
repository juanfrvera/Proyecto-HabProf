namespace Libreria.Models
{
    public class Proveedor
    {
        private string telefono;
        private string nombre;
        private string email;
        private string contacto;
        private string observaciones;

        public Proveedor(string telefono, string nombre, string email, string contacto, string observaciones)
        {
            this.telefono = telefono;
            this.nombre = nombre;
            this.email = email;
            this.contacto = contacto;
            this.observaciones = observaciones;
        }

        public string Telefono => telefono;

        public string Nombre => nombre;

        public string Email => email;

        public string Contacto => contacto;

        public string Observaciones => observaciones;
    }
}