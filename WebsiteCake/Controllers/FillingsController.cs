using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteCake.Logic.Categories;
using WebsiteCake.Logic.Fillings;
using WebsiteCake.Models;
using WebsiteCake.Storage.Entities;

namespace WebsiteCake.Controllers
{
    public class FillingsController : Controller
    {
        // GET: FillingsController
        private readonly IFillingManger _fillingManger;

        public FillingsController(IFillingManger fillingManger)
        {
            _fillingManger = fillingManger;
        }

        [HttpGet]
        [Route("fillings")]
        public async Task<IList<Filling>> GetAll() => await _fillingManger.GetAll();

        public async Task<IActionResult> index()
        {
            var fillings = await _fillingManger.GetAll();

            return View(fillings);
        }

        [HttpPut]
        [Route("fillings")]
        public Task Create([FromBody] CreateFillingRequest request) => _fillingManger.Create(request.Name);

    }
}
