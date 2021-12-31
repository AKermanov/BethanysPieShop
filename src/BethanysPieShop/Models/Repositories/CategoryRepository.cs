namespace BethanysPieShop.Models.Repositories
{
    using System.Linq;
    using System.Collections.Generic;
    using BethanysPieShop.Models.Repositories.Contracts;

    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories.ToList();
    }
}
