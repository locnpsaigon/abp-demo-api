using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpDemoApi.Entities
{
    public class Book : AuditedEntity<Guid>
    {
        protected Book()
        {
            
        }

        public Book(Guid guid)
        {
            Id = guid;
        }

        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2500)]
        public string Description { get; set; }
    }
}
