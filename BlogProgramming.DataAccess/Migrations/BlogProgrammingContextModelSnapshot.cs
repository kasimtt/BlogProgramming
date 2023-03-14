﻿// <auto-generated />
using System;
using BlogProgramming.DataAccess.Concretes.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogProgramming.DataAccess.Migrations
{
    [DbContext(typeof(BlogProgrammingContext))]
    partial class BlogProgrammingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WievsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6816),
                            CreatedByName = "InitialCreate",
                            Date = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6814),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6816),
                            Note = "C# Article",
                            SeoAuthor = "kasım islam TATLI",
                            SeoDescription = "C# 9 ve 11 yenilikleri",
                            SeoTags = "c#, .net core, asp.net core, .net framework",
                            Thumbnail = "Default.jpg",
                            Title = "C# 9 ve .net 6 yenilikleri",
                            UserId = 1,
                            WievsCount = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6821),
                            CreatedByName = "InitialCreate",
                            Date = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6820),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6821),
                            Note = "C++ Article",
                            SeoAuthor = "kasım islam TATLI",
                            SeoDescription = "C++ 9 ve 19 yenilikleri",
                            SeoTags = "c++",
                            Thumbnail = "Default.jpg",
                            Title = "C++ 11 ve 19 yenilikleri",
                            UserId = 1,
                            WievsCount = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır",
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6825),
                            CreatedByName = "InitialCreate",
                            Date = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6824),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6825),
                            Note = "java Article",
                            SeoAuthor = "kasım islam TATLI",
                            SeoDescription = "java 11 ve spring boot yenilikleri",
                            SeoTags = "java, spring boot",
                            Thumbnail = "Default.jpg",
                            Title = "java 11 ve spring boot yenilikleri",
                            UserId = 1,
                            WievsCount = 1
                        });
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7625),
                            CreatedByName = "InitialCreate",
                            Description = "C# ile en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7625),
                            Name = "C#",
                            Note = "C# blog categorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7628),
                            CreatedByName = "InitialCreate",
                            Description = "C++ ile en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7629),
                            Name = "C++",
                            Note = "C++ blog categorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7631),
                            CreatedByName = "InitialCreate",
                            Description = "Java ile en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7631),
                            Name = "Java",
                            Note = "Java blog categorisi"
                        });
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1565),
                            CreatedByName = "InitialCreate",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1565),
                            Note = "C# blog yorumu",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce lacinia nunc leo, vel sodales urna ultrices in. Cras lacinia pretium mi nec malesuada. Praesent venenatis nisi id dolor sagittis, id porta tellus tempus. Nam nisi sem, hendrerit ut iaculis non, lacinia eu ex. Nulla fermentum congue dolor vitae finibus. In in libero quis dui accumsan auctor. Donec imperdiet nulla non lectus mattis, lacinia efficitur est porta. Fusce nec viverra mi, sit amet condimentum ex. Morbi in sodales sapien. Duis nisl sem, malesuada eu ipsum nec, consequat efficitur nisi."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1567),
                            CreatedByName = "InitialCreate",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1568),
                            Note = "C++ blog yorumu",
                            Text = "Phasellus eu auctor felis. Mauris efficitur convallis blandit. Aenean commodo velit id massa volutpat, eget interdum magna auctor. Sed laoreet urna a ipsum ultricies, eu laoreet mauris porta. Curabitur vulputate posuere ultrices. Nunc sagittis metus quis lacus aliquet, in molestie risus elementum. Proin vitae risus vitae ipsum tempus gravida quis sit amet odio. Ut elementum placerat accumsan. Ut in fringilla augue. Sed tincidunt cursus rutrum. Cras eget tristique ex. Vestibulum accumsan velit quis massa pharetra, ac malesuada ex gravida. Donec mollis et risus non convallis."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1569),
                            CreatedByName = "InitialCreate",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1571),
                            Note = "java blog yorumu",
                            Text = "Sed nisi risus, tincidunt eu augue et, ultrices volutpat tellus. Phasellus eu erat eu elit lacinia sodales. Praesent finibus, tortor quis faucibus fringilla, ante nisl dapibus lectus, vitae lobortis augue augue cursus mauris. Cras metus turpis, aliquet in nibh non, rutrum lacinia tortor. Donec leo augue, maximus ut molestie ut, ultricies quis nunc. Sed porta dictum facilisis."
                        });
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(2445),
                            CreatedByName = "InitialCreate",
                            Description = "Admin rolü, tüm haklara sahiptir",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(2446),
                            Name = "Admin",
                            Note = "bu admin rolüdür."
                        });
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(4535),
                            CreatedByName = "InitialCreate",
                            Description = "ilk admin",
                            Email = "kasimislamtatli@gmail.com",
                            FirstName = "kasım islam",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Tatlı",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(4535),
                            Note = "Otomotik admin",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "C:\\Users\\Kasim\\Pictures",
                            RoleId = 1,
                            UserName = "kasimtt"
                        });
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Article", b =>
                {
                    b.HasOne("BlogProgramming.Entities.Concretes.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProgramming.Entities.Concretes.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Comment", b =>
                {
                    b.HasOne("BlogProgramming.Entities.Concretes.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.User", b =>
                {
                    b.HasOne("BlogProgramming.Entities.Concretes.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BlogProgramming.Entities.Concretes.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
