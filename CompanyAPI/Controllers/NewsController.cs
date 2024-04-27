using CompanyAPI.Database;
using CompanyAPI.Database.Models;
using CompanyAPI.ModelsNews;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
        private readonly ApplicationContext db;

        public NewsController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNews request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var news = new News
            {
                title = request.Subject,
                description = request.Description,
                created_at = DateTime.UtcNow,
                updated_at = null
            };

            await db.News.AddAsync(news);

            await db.SaveChangesAsync();

            return Json(news);
        }

        [HttpGet]
        public async Task<IActionResult> Read([FromBody] GetById request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var news = await db.News.FindAsync(request.Id);
            if (news == null)
            {
                return NotFound();
            }

            return Json(news);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateNews request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var news = await db.News.FindAsync(request.Id);
            if (news == null)
            {
                return NotFound();
            }

            if (request.Subject != null)
            {
                news.title = request.Subject;
            }

            if (request.Description != null)
            {
                news.description = request.Description;
            }

            news.updated_at = DateTime.UtcNow;
            await db.SaveChangesAsync();

            return Json(news);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteById request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var news = await db.News.FindAsync(request.Id);
            if (news == null)
            {
                return NotFound();
            }

            db.News.Remove(news);

            await db.SaveChangesAsync();

            return Ok();
        }
    }
}
