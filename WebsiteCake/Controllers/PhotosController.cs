using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteCake.Controllers
{
    namespace WebsiteCake.Controllers
    {
        [Route("photos")]
        public class PhotosController : Controller
        {
            private readonly IWebHostEnvironment _env;

            public PhotosController(IWebHostEnvironment env)
            {
                _env = env;
            }
            [HttpGet("")]
            public IActionResult GetImages()
            {
                var path = Path.Combine(_en v.WebRootPath, "images");
                var images = Directory.GetFiles(path)
                                      .Select(x => Path.GetFileName(x))
                                      .Select(x => Url.Action("GetImage", new { id = Path.GetFileNameWithoutExtension(x) }))
                                      .ToList();

                return Ok(images);
            }

            [HttpGet("{id}")]
            public IActionResult GetImage(string id)
            {
                var path = Path.Combine(_env.WebRootPath, "images", $"{id}.png");
                var mimeType = "image/png"; ; 
                var fileStream = new FileStream(path, FileMode.Open);

                return new FileStreamResult(fileStream, mimeType);
            }
        }
    }
}
