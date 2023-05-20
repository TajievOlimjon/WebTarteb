//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using Microsoft.EntityFrameworkCore;
using WebApi.Models.Tickets;

namespace WebApi.Brokers.Storages
{
    public partial class StorageBroker : IStorageBroker
    {
        public DbSet<Ticket> Tickets { get; set; }

        public ValueTask<Ticket> DeleteTicketByIdAsync(Ticket task)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Ticket> GetAllTicketsAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Ticket> GetTicketByIdAsync(Ticket task)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Ticket> InsertTicketAsync(Ticket task)
        {
            var broker = new StorageBroker(_configuration);

            await broker.Tickets.AddAsync(task);

            await broker.SaveChangesAsync();

            return task;
        }

        public ValueTask<Ticket> UpdateTicketAsync(Ticket task)
        {
            throw new NotImplementedException();
        }
    }
}
