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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a=>a.Id);
            builder.Property(a=>a.Id).ValueGeneratedOnAdd();
            builder.Property(a=>a.Title).HasMaxLength(100);
            builder.Property(a=>a.Title).IsRequired(true);
            builder.Property(a=>a.Content).IsRequired(true);
            builder.Property(a=>a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a=>a.Date).IsRequired(true);
            builder.Property(a=>a.SeoAuthor).IsRequired(true);
            builder.Property(a=>a.SeoAuthor).HasMaxLength(50);
            builder.Property(a=>a.SeoDescription).HasMaxLength(150);
            builder.Property(a=>a.SeoDescription).IsRequired(true);
            builder.Property(a=>a.SeoTags).IsRequired(true);
            builder.Property(a=>a.SeoTags).HasMaxLength(70);
            builder.Property(a=>a.WievsCount).IsRequired(true);
            builder.Property(a=>a.CommentCount).IsRequired(true);
            builder.Property(a=>a.Thumbnail).IsRequired(true);
            builder.Property(a=> a.Thumbnail).HasMaxLength(250);
            builder.Property(a=>a.CreatedByName).IsRequired(true);
            builder.Property(a=>a.CreatedByName).HasMaxLength(50);
            builder.Property(a=>a.ModifiedByName).IsRequired(true);
            builder.Property(a=> a.ModifiedByName).HasMaxLength(50);
            builder.Property(a=>a.CreateDate).IsRequired(true);
            builder.Property(a=>a.ModifiedDate).IsRequired(true);
            builder.Property(a=>a.IsDeleted).IsRequired(true);
            builder.Property(a=>a.IsActive).IsRequired(true);
            builder.Property(a=>a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a=>a.CategoryId);
            builder.HasOne<User>(a =>a.User).WithMany(u=>u.Articles).HasForeignKey(a=>a.UserId);
            builder.ToTable("Articles");
            builder.HasData(

                new Article
                {
                    Id = 1,
                    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    CategoryId = 1,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    Title = "C# 9 ve .net 6 yenilikleri",
                    SeoAuthor = "kasım islam TATLI",
                    UserId = 1,
                    Thumbnail = "Default.jpg",
                    SeoTags = "c#, .net core, asp.net core, .net framework",
                    SeoDescription = "C# 9 ve 11 yenilikleri",
                    WievsCount = 1,
                    CreateDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "C# Article"

                },
                new Article
                {
                    Id = 2,
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                    CategoryId = 2,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    Title = "C++ 11 ve 19 yenilikleri",
                    SeoAuthor = "kasım islam TATLI",
                    UserId = 1,
                    Thumbnail = "Default.jpg",
                    SeoTags = "c++",
                    SeoDescription = "C++ 9 ve 19 yenilikleri",
                    WievsCount = 1,
                    CreateDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "C++ Article"
                },
                new Article
                {
                    Id = 3,
                    Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır",
                    CategoryId = 3,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    Title = "java 11 ve spring boot yenilikleri",
                    SeoAuthor = "kasım islam TATLI",
                    UserId = 1,
                    Thumbnail = "Default.jpg",
                    SeoTags = "java, spring boot",
                    SeoDescription = "java 11 ve spring boot yenilikleri",
                    WievsCount = 1,
                    CreateDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "java Article"
                }


                );
        }
    }
}
