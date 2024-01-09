﻿using AbpDemoApi.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbpDemoApi.EntityFrameworkCore;

public static class AbpDemoApiDbContextModelCreatingExtensions
{
    public static void ConfigureAbpDemoApi(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(AbpDemoApiDbProperties.DbTablePrefix + "Questions", AbpDemoApiDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Book>(b =>
        {
            //Configure table & schema name
            b.ToTable(AbpDemoApiDbProperties.DbTablePrefix + "Books", AbpDemoApiDbProperties.DbSchema);

            b.ConfigureByConvention();

        });
    }
}
