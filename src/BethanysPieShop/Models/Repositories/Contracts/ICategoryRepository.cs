namespace BethanysPieShop.Models.Repositories.Contracts
{
    using System.Collections.Generic;
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
