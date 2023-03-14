using BlogProgramming.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Concretes.EntityFramework.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c=>c.Name).IsRequired(true);
            builder.Property(c => c.Description).HasMaxLength(250);
            builder.Property(c => c.CreatedByName).IsRequired(true);
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired(true);
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreateDate).IsRequired(true);
            builder.Property(c => c.ModifiedDate).IsRequired(true);
            builder.Property(c => c.IsDeleted).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Categories");
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "C#",
                    Description = "C# ile en güncel bilgiler",
                    CreateDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "C# blog categorisi",
                
                 },
                new Category
                {
                    Id = 2,
                    Name = "C++",
                    Description = "C++ ile en güncel bilgiler",
                    CreateDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "C++ blog categorisi",

                },
                new Category
                {
                    Id = 3,
                    Name = "Java",
                    Description = "Java ile en güncel bilgiler",
                    CreateDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "Java blog categorisi",
                }
            
            );
        }
    }
}
