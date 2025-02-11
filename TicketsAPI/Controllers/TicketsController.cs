// TicketsAPI/Controllers/TicketsController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    private static readonly List<Ticket> Tickets = new List<Ticket>
    {
        new Ticket { Id = 1, VisitorName = "John Doe", Email = "john@example.com", TicketType = "Adult", Quantity = 2 },
        new Ticket { Id = 2, VisitorName = "Jane Smith", Email = "jane@example.com", TicketType = "Child", Quantity = 1 }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Ticket>> GetTickets()
    {
        return Ok(Tickets);
    }

    [HttpGet("{id}")]
    public ActionResult<Ticket> GetTicket(int id)
    {
        var ticket = Tickets.Find(t => t.Id == id);
        if (ticket == null)
        {
            return NotFound();
        }
        return Ok(ticket);
    }
}