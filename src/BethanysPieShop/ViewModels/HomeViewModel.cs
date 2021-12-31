namespace BethanysPieShop.ViewModels
{
    using BethanysPieShop.Models;
    using System.Collections.Generic;

    public class HomeViewModel
    {
       public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
