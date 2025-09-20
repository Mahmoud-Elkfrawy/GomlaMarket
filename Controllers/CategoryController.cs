using GomlaMarket.Data;
using GomlaMarket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GomlaMarket.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _dbContext;
        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _dbContext.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
