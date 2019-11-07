namespace Libreria.BusinessLogic.Dto
{
    public class LineaDeVentaDto
    {
        public int cantidad, idMaterial;
        public float precio, descuento;
        public MaterialDto Material { get; set; }
    }
}