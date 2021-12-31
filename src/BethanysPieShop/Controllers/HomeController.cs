namespace BethanysPieShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using BethanysPieShop.ViewModels;
    using BethanysPieShop.Models.Repositories.Contracts;

    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
