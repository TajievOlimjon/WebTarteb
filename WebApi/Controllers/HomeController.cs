using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Brokers.Storages;
using Local = WebApi.Models.Tickets;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStorageBroker _storageBroker;

        public HomeController(IStorageBroker storageBroker) =>
          _storageBroker = storageBroker;

        [HttpGet("GetHomeMessage")]
        public ActionResult<string> GetHomeMessage() => "Tarteb is running";

        [HttpPost("AddNewTask")]
        public async ValueTask<IActionResult> PostTaskAsync()
        {
            var task = new Local.Ticket
            {
                Id = Guid.NewGuid(),
                CreatedUserId=Guid.NewGuid(),
                UpdatedUserId=Guid.NewGuid(),
                Description="test",
                Title="test",
                AssigneeId=Guid.NewGuid(),
                Status=Local.TicketStatus.DONE
            };

            var result = await _storageBroker.InsertTicketAsync(task);

            return Ok(result);
        }
    }
}
