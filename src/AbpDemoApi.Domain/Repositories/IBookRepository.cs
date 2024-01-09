using AbpDemoApi.Entities;
using System;
using Volo.Abp.Domain.Repositories;

namespace AbpDemoApi.Repositories
{
    public interface IBookRepository : IRepository<Book, Guid>
    {
    }
}
