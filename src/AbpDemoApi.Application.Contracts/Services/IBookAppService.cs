using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemoApi.Services
{
    public interface IBookAppService
    {
        Task<BookDto> CreateAsync(CreateBookDto dto);
        Task<List<BookDto>> GetBooksAsync();
    }
}
