namespace PatikaWeek12PratikSurvivor.Entites
{
    public class CategoryEntity : BaseEntity
    {
        public int Name { get; set; }

        //Relotinal Propetry
        public List<CompetitorEntity> Competitors { get; set; }
    }
}
