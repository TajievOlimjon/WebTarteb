//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using Microsoft.EntityFrameworkCore;
using WebApi.Models.Tasks;
using Task = WebApi.Models.Tasks.Task;

namespace WebApi.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
