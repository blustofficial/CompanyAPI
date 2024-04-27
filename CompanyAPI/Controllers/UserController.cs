using CompanyAPI.Database;
using CompanyAPI.Database.Models;
using CompanyAPI.ModelsUser;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.Controllers
{
    [Route("personnel")]
    public class UserController : Controller
    {
        private readonly ApplicationContext db;

        public UserController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PostUser request)
        {
            if(!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = new Users
            {
                name = request.Name,
                role_id = request.RoleId,
                created_at = DateTime.UtcNow,
                updated_at = null
            };

            await db.Users.AddAsync(user);

            await db.SaveChangesAsync();

            return Json(user);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUser request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await db.Users.FindAsync(request.Id);
            if(user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            await db.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PutUser request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await db.Users.FindAsync(request.Id);
            if(user == null)
            {
                return NotFound();
            }

            if(request.Name != null)
            {
                user.name = request.Name;
            }

            if(request.Password != null)
            {
                user.password = request.Password;
            }

            if(request.RoleId != null)
            {
                user.role_id = request.RoleId.Value;
            }

            user.updated_at = DateTime.UtcNow;
            await db.SaveChangesAsync();

            return Json(user);
        }

        [HttpPut]
        public async Task<IActionResult> Get([FromBody] GetUser request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await db.Users.FindAsync(request.Id);
            if(user == null)
            {
                return NotFound();
            }

            return Json(user);
        }
    }
}