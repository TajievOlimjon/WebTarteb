//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================


using Local = WebApi.Models.Tasks;

namespace WebApi.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Local.Task> InsertTaskAsync(Local.Task task);
    }
}
