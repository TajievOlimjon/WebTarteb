//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================


using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext,IStorageBroker
    {
        private readonly IConfiguration _configuration;
        public StorageBroker(IConfiguration configuration)
        {
            _configuration = configuration;
            this.Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString =
                _configuration.GetConnectionString(name: "DefaultConnection");

            optionsBuilder.UseNpgsql(connectionString: connectionString);
        }
    }
}
