using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDoListWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetToDoItems()
        {
            var toDoItems = new[]
            {
                new { Id = 1, Title = "Buy groceries", IsCompleted = false },
                new { Id = 2, Title = "Clean the house", IsCompleted = true },
                new { Id = 3, Title = "Finish the project", IsCompleted = false }
            };
            return Ok(toDoItems);
        }
    }
}
