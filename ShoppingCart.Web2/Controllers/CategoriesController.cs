using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Service.Infrastructure;
using ShoppingCart.Web2.Models.ViewModels;

namespace ShoppingCart.Web2.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategory _category;
        private IMapper _mapper;
        public CategoriesController(ICategory category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var AllCategories = _category.GetAllCategories();
            var mappedCategories = _mapper.Map<List<CategoryViewModel>>(AllCategories);
            //List<CategoryViewModel> vm = new List<CategoryViewModel>();
            //foreach (var category in AllCategories)
            //{
            //    vm.Add(new CategoryViewModel
            //    {
            //        Id = item.Id,
            //        Name = item.Name
            //    });
            //}
            return View(mappedCategories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
