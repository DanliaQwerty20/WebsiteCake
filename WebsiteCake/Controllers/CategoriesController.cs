using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteCake.Logic.Categories;
using WebsiteCake.Models;
using WebsiteCake.Storage.Entities;

namespace WebsiteCake.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryManger _categoryManger;

        public CategoriesController(ICategoryManger categoryManger)
        {
            _categoryManger = categoryManger;
        }

        [HttpGet]
        [Route("categories")]
        public async Task<IList<Сategory>> GetAll() => await _categoryManger.GetAll();

        public async Task<IActionResult> Main() {
            var category = await _categoryManger.GetAll();
            
            return View(category);
        }

        [HttpPut]
        [Route("categories")]
        public Task Create([FromBody] CreateCategoryRequest request) => _categoryManger.Create(request.Name);
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View();
        }
        [HttpDelete]
        [Route("categories/{id}")]
        public Task Delete(int id)=> _categoryManger.Delete(id);
    }
}
