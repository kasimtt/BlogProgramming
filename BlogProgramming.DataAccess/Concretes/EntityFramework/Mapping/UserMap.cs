using BlogProgramming.Entities.Concretes;
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
            builder.Property(u=>u.LastName).IsRequired();
            builder.Property(u=>u.LastName).HasMaxLength(50);
            builder.Property(u=>u.Email).IsRequired();
            builder.Property(u=>u.Email).HasMaxLength(50);
            builder.Property(u=>u.PasswordHash).IsRequired();
            builder.Property(u=>u.PasswordHash).HasMaxLength(250);
            builder.Property(u=>u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(200);
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






            //comment icinde
            //  builder.HasOne<Article>(c => c.Article).WithMany(a=>a.Comments).HasForeignKey(c=>c.ArticleId);


            /*    public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public byte[] PasswordHash { get; set; }
            public string Picture { get; set; }
            public string Description { get; set; }
            public int RoleId { get; set; }
            public Role Role { get; set; }
            public ICollection<Article> Articles { get; set; }    */
        }
    }
}
