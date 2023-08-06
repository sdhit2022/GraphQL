using Graph_qL.Intefaces;
using Graph_qL.Models;

namespace Graph_qL.Repositories
{
    public class SuperheroRepository : ISuperheroRepository
        {
            private readonly ApplicationDbContext _appDbContext;

            public SuperheroRepository(ApplicationDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }
        }
}
