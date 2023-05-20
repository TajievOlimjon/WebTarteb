//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================


using WebApi.Models.Tickets;

namespace WebApi.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Ticket> GetAllTicketsAsync(Ticket task);
        ValueTask<Ticket> GetTicketByIdAsync(Ticket task);
        ValueTask<Ticket> InsertTicketAsync(Ticket task);
        ValueTask<Ticket> UpdateTicketAsync(Ticket task);
        ValueTask<Ticket> DeleteTicketByIdAsync(Ticket task);
    }
}
