namespace Graph_qL.Models
{
    public class Query
    {
        public IQueryable<Superhero> GetSuperheroes =>
           new List<Superhero>().AsQueryable();
    }
}
