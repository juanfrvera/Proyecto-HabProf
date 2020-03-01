namespace Libreria.BusinessLogic.Dto
{
    public class LineaDeVentaDto : DtoBase
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Descuento { get; set; }
        public MaterialDto Material { get; set; }
    }
}