namespace BethanysPieShop.Models
{
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => _appDbContext.Pies.Include(c => c.Category).ToList();
        public IEnumerable<Pie> PiesOfTheWeek => _appDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek).ToList();
        public Pie GetPieById(int pieId) => _appDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
    }
}