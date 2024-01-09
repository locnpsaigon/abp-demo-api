using AbpDemoApi.Entities;
using AbpDemoApi.Repositories;
using AbpDemoApi.Services;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpDemoApi.Services
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly IBookRepository _bookRepository;

        public BookAppService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookDto> CreateAsync(CreateBookDto dto)
        {
            var book = new Book(GuidGenerator.Create()) { Title = dto.Title, Description = dto.Description };
            await _bookRepository.InsertAsync(book);
            return ObjectMapper.Map<Book, BookDto>(book);
        }

        public async Task<List<BookDto>> GetBooksAsync()
        {
            var books = await _bookRepository.GetListAsync();

            return ObjectMapper.Map<List<Book>, List<BookDto>>(books);
        }
    }
}
