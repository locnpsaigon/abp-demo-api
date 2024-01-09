using AbpDemoApi.Entities;
using AbpDemoApi.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemoApi.Repositories
{
    public class BookRepository : EfCoreRepository<AbpDemoApiDbContext, Book, Guid>, IBookRepository
    {
        public BookRepository(IDbContextProvider<AbpDemoApiDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
