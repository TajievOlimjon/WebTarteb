//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================


using Microsoft.AspNetCore.Mvc;
using WebApi.Brokers.Storages;
using WebApi.Enums;
using WebApi.Models.Tickets;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStorageBroker _storageBroker;

        public HomeController(IStorageBroker storageBroker) =>
          _storageBroker = storageBroker;

        [HttpGet("GetAllTickets")]
        public async ValueTask<IActionResult> GetAllTicketsAsync()
        {
            return Ok(await _storageBroker.GetAllTicketsAsync());
        }

        [HttpPost("AddNewTicket")]
        public async ValueTask<IActionResult> PostTicketAsync()
        {
            var task = new Ticket
            {
                Id = Guid.NewGuid(),
                CreatedUserId = Guid.NewGuid(),
                UpdatedUserId = Guid.NewGuid(),
                Description = "test",
                Title = "test",
                AssigneeId = Guid.NewGuid(),
                Status = TicketStatus.DONE
            };

            var result = await _storageBroker.InsertTicketAsync(task);

            return Ok(result);
        }
        [HttpPut("UpdateTicket")]
        public async ValueTask<IActionResult> PutTicketAsync(Ticket ticket)
        {
            var result = await _storageBroker.UpdateTicketAsync(ticket);

            return Ok(result);
        }
        [HttpDelete("DeleteTicket")]
        public async ValueTask<IActionResult> DeleteTicketAsync(Ticket ticket)
        {
            var result = await _storageBroker.DeleteTicketByIdAsync(ticket);

            return Ok(result);
        }
    }
}
