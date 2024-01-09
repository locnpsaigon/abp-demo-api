using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpDemoApi.Services
{
    public class CreateBookDto
    {
        [Required(ErrorMessage = "Tiêu đề ko đc rỗng")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
