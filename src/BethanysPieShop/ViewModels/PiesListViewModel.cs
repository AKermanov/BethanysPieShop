namespace BethanysPieShop.ViewModels
{
    using BethanysPieShop.Models;
    using System.Collections.Generic;

    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
