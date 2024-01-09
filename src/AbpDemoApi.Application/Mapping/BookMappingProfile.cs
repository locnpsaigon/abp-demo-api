using AbpDemoApi.Services;
using AbpDemoApi.Entities;
using AutoMapper;

namespace AbpDemoApi.Mapping
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<Book, BookDto>();
        }
    }
}
