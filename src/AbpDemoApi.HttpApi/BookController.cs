using AbpDemoApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace AbpDemoApi
{
    [Area(AbpDemoApiRemoteServiceConsts.ModuleName)]
    [RemoteService(Name = AbpDemoApiRemoteServiceConsts.RemoteServiceName)]
    [Route("api/AbpDemoApi/book")]
    public class BookController : AbpDemoApiController, IBookAppService
    {
        private readonly IBookAppService _bookAppService;

        public BookController(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        [HttpPost]
        public async Task<BookDto> CreateAsync(CreateBookDto dto)
        {
            return await _bookAppService.CreateAsync(dto);
        }

        [HttpGet]
        public async Task<List<BookDto>> GetBooksAsync()
        {
            return await _bookAppService.GetBooksAsync();
        }
    }
}
