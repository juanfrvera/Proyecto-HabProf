namespace Libreria.BusinessLogic
{
    public class MaterialAutor
    {
        public MaterialAutor(Material m, Autor a)
        {
            Material = m;
            MaterialId = m.ID;

            Autor = a;
            AutorId = a.ID;
        }
        
        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}