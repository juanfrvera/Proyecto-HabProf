namespace Libreria.BusinessLogic.Dto
{
    public class EditorialDto : DtoBase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Anulado { get; set; }
    }
}