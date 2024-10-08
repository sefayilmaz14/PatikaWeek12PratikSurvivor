namespace PatikaWeek12PratikSurvivor.Entites
{
    public class CompetitorEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; }

        //Relotinal Propetry

        public CategoryEntity Category { get; set; }
    }
}
