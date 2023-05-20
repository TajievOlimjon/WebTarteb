//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using WebApi.Enums;

namespace WebApi.Models.Tickets
{
    public class Ticket : BaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; } = null;
        public Priority Priority { get; set; }
        public DateTimeOffset Deadline { get; set; }
        public Guid? AssigneeId { get; set; }
        public TicketStatus Status { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }
    }
}
