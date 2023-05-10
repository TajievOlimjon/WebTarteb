//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using Microsoft.EntityFrameworkCore;
using Local = WebApi.Models.Tasks;

namespace WebApi.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Local.Task> Tasks { get; set; }
        public async ValueTask<Local.Task> InsertTaskAsync(Local.Task task)
        {
            var broker = new StorageBroker(_configuration);

            await broker.Tasks.AddAsync(task);

            await broker.SaveChangesAsync();

            return task;
        }
    }
}
