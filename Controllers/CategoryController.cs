using GomlaMarket.Data;
using GomlaMarket.Models;
using GomlaMarket.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GomlaMarket.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository;
        
        public CategoryController(CategoryRepository _categoryRepository)
        {
            //_dbContext = dbContext;
            categoryRepository = _categoryRepository;
        }
        public IActionResult Index()
        {

            
            //List<Category> objCategoryList = _dbContext.Categories.ToList();
            List<Category> objCategoryList = categoryRepository.Get();
            return View(objCategoryList);
        }
        public IActionResult _CategoryPanalPartial(int id)
        {
            Category subCategory = categoryRepository.Get().FirstOrDefault(x => x.Id == id);

            return PartialView("_CategoryPanalPartial", subCategory);
        }

    }
}
