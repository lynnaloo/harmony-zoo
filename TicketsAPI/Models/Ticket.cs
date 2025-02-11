// TicketsAPI/Models/Ticket.cs
public class Ticket
{
    public int Id { get; set; }
    public string VisitorName { get; set; }
    public string Email { get; set; }
    public string TicketType { get; set; }
    public int Quantity { get; set; }
}