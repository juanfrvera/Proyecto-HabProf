namespace Libreria.BusinessLogic.Dto
{
    public class MedioDePagoDto : DtoBase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float Comision { get; set; }
        public bool Anulado { get; set; }
        public TipoDeComision TipoDeComision { get; set; }
    }
}