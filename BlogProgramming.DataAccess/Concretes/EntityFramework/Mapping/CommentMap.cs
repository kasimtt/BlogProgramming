using BlogProgramming.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Concretes.EntityFramework.Mapping
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();
            builder.Property(c=>c.Text).HasMaxLength(500);
            builder.Property(c=>c.Text).IsRequired(true);
            builder.Property(c => c.CreatedByName).IsRequired(true);
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired(true);
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreateDate).IsRequired(true);
            builder.Property(c => c.ModifiedDate).IsRequired(true);
            builder.Property(c => c.IsDeleted).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.HasOne<Article>(c => c.Article).WithMany(a=>a.Comments).HasForeignKey(c=>c.ArticleId);
            builder.ToTable("Comments");
            builder.HasData(
                new Comment
                {
                    Id = 1,
                    ArticleId = 1,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce lacinia nunc leo, vel sodales urna ultrices in. Cras lacinia pretium mi nec malesuada. Praesent venenatis nisi id dolor sagittis, id porta tellus tempus. Nam nisi sem, hendrerit ut iaculis non, lacinia eu ex. Nulla fermentum congue dolor vitae finibus. In in libero quis dui accumsan auctor. Donec imperdiet nulla non lectus mattis, lacinia efficitur est porta. Fusce nec viverra mi, sit amet condimentum ex. Morbi in sodales sapien. Duis nisl sem, malesuada eu ipsum nec, consequat efficitur nisi.",
                    CreateDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "C# blog yorumu"

                },
                new Comment
                {
                    Id = 2,
                    ArticleId = 2,
                    Text = "Phasellus eu auctor felis. Mauris efficitur convallis blandit. Aenean commodo velit id massa volutpat, eget interdum magna auctor. Sed laoreet urna a ipsum ultricies, eu laoreet mauris porta. Curabitur vulputate posuere ultrices. Nunc sagittis metus quis lacus aliquet, in molestie risus elementum. Proin vitae risus vitae ipsum tempus gravida quis sit amet odio. Ut elementum placerat accumsan. Ut in fringilla augue. Sed tincidunt cursus rutrum. Cras eget tristique ex. Vestibulum accumsan velit quis massa pharetra, ac malesuada ex gravida. Donec mollis et risus non convallis.",
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "C++ blog yorumu"

                },

                new Comment
                {
                    Id = 3,
                    ArticleId = 3,
                    Text = "Sed nisi risus, tincidunt eu augue et, ultrices volutpat tellus. Phasellus eu erat eu elit lacinia sodales. Praesent finibus, tortor quis faucibus fringilla, ante nisl dapibus lectus, vitae lobortis augue augue cursus mauris. Cras metus turpis, aliquet in nibh non, rutrum lacinia tortor. Donec leo augue, maximus ut molestie ut, ultricies quis nunc. Sed porta dictum facilisis.",
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "java blog yorumu"
                }
                
                );

           




        }
    }
}
