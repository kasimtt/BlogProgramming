﻿using BlogProgramming.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Concretes.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u=>u.FirstName).IsRequired();
            builder.Property(u=>u.FirstName).HasMaxLength(50);
            builder.Property(u=>u.UserName).IsRequired();
            builder.Property(u=>u.UserName).HasMaxLength(50);
            builder.Property(u=>u.LastName).IsRequired();
            builder.Property(u=>u.LastName).HasMaxLength(50);
            builder.Property(u=>u.Email).IsRequired();
            builder.Property(u=>u.Email).HasMaxLength(50);
            builder.HasIndex(u=>u.Email).IsUnique();
            builder.Property(u=>u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.Property(u=>u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            builder.Property(u=>u.Description).HasMaxLength(200);
            builder.HasOne<Role>(u=>u.Role).WithMany(r=>r.Users).HasForeignKey(u=>u.RoleId);
            builder.Property(u => u.CreatedByName).IsRequired(true);
            builder.Property(u => u.CreatedByName).HasMaxLength(50);
            builder.Property(u => u.ModifiedByName).IsRequired(true);
            builder.Property(u => u.ModifiedByName).HasMaxLength(50);
            builder.Property(u => u.CreateDate).IsRequired(true);
            builder.Property(u => u.ModifiedDate).IsRequired(true);
            builder.Property(u => u.IsDeleted).IsRequired(true);
            builder.Property(u => u.IsActive).IsRequired(true);
            builder.ToTable("Users");
            builder.HasData(new User
            {
                Id = 1,
                FirstName = "kasım islam",
                LastName = "Tatlı",
                UserName = "kasimtt",
                Email = "kasimislamtatli@gmail.com",
                CreateDate = DateTime.Now,
                CreatedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                IsActive = true,
                IsDeleted = false,
                Description = "ilk admin",
                Note = "Otomotik admin",
                RoleId = 1,
                PasswordHash = Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500"),
                Picture = "C:\\Users\\Kasim\\Pictures"

            }) ;

        }
    }
}
