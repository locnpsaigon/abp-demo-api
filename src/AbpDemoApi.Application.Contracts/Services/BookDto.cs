using System;

namespace AbpDemoApi.Services
{
    public class BookDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
