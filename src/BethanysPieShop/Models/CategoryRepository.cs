﻿namespace BethanysPieShop.Models
{
    using System.Linq;
    using System.Collections.Generic;
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
