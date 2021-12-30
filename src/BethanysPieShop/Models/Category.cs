namespace BethanysPieShop.Models
{
    using System.Collections.Generic;
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Pie> Pies { get; set; } = new List<Pie>();
    }
}
