using CompanyAPI.Database;
using CompanyAPI.ModelsStatement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.Controllers
{
    [Route("statement")]
    public class StatementsController : Controller
    {
        private readonly ApplicationContext db;

        public StatementsController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatementById([FromBody] GetById request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var statement = await db.Statements.FindAsync(request.StatementId);

            return statement == null
             ? NotFound()
             : Json(statement);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> ReadAll()
        {
            var statements = await db.Statements.ToListAsync();
            return Json(statements);
        }

        [Route("role")]
        [HttpPut]
        public async Task<IActionResult> ChangeRole([FromBody] PutRole request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var statement = await db.Statements.FindAsync(request.StatementId);
            if (statement == null)
            {
                return NotFound();
            }

            statement.status = request.RoleId;
            statement.updated_at = DateTime.UtcNow;
            await db.SaveChangesAsync();

            return Json(statement);
        }

        [Route("role")]
        [HttpGet]
        public async Task<IActionResult> GetByRole([FromBody] GetByRole request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var statements = await db.Statements.Where(obj => obj.status == request.RoleId)
                .ToListAsync();

            if (statements == null || statements.Count == 0)
            {
                return NotFound();
            }

            return Json(statements);
        }

        [Route("employee")]
        [HttpPut]
        public async Task<IActionResult> ChangeEmployee([FromBody] PutEmployee request)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            var statement = await db.Statements.FindAsync(request.StatementId);
            if (statement == null)
            {
                return NotFound();
            }

            statement.user_id = request.EmployeeId;
            statement.updated_at = DateTime.UtcNow;
            await db.SaveChangesAsync();

            return Json(statement);
        }
    }
}
