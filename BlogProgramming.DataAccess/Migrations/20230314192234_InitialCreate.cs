using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProgramming.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WievsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "CreatedByName", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7625), "InitialCreate", "C# ile en güncel bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7625), "C#", "C# blog categorisi" },
                    { 2, new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7628), "InitialCreate", "C++ ile en güncel bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7629), "C++", "C++ blog categorisi" },
                    { 3, new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7631), "InitialCreate", "Java ile en güncel bilgiler", true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(7631), "Java", "Java blog categorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "CreatedByName", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(2445), "InitialCreate", "Admin rolü, tüm haklara sahiptir", true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(2446), "Admin", "bu admin rolüdür." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "CreatedByName", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "UserName" },
                values: new object[] { 1, new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(4535), "InitialCreate", "ilk admin", "kasimislamtatli@gmail.com", "kasım islam", true, false, "Tatlı", "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(4535), "Otomotik admin", new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 }, "C:\\Users\\Kasim\\Pictures", 1, "kasimtt" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreateDate", "CreatedByName", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "WievsCount" },
                values: new object[,]
                {
                    { 1, 1, 1, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6816), "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6814), true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6816), "C# Article", "kasım islam TATLI", "C# 9 ve 11 yenilikleri", "c#, .net core, asp.net core, .net framework", "Default.jpg", "C# 9 ve .net 6 yenilikleri", 1, 1 },
                    { 2, 2, 1, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6821), "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6820), true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6821), "C++ Article", "kasım islam TATLI", "C++ 9 ve 19 yenilikleri", "c++", "Default.jpg", "C++ 11 ve 19 yenilikleri", 1, 1 },
                    { 3, 3, 1, "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6825), "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6824), true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 370, DateTimeKind.Local).AddTicks(6825), "java Article", "kasım islam TATLI", "java 11 ve spring boot yenilikleri", "java, spring boot", "Default.jpg", "java 11 ve spring boot yenilikleri", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreateDate", "CreatedByName", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1565), "InitialCreate", true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1565), "C# blog yorumu", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce lacinia nunc leo, vel sodales urna ultrices in. Cras lacinia pretium mi nec malesuada. Praesent venenatis nisi id dolor sagittis, id porta tellus tempus. Nam nisi sem, hendrerit ut iaculis non, lacinia eu ex. Nulla fermentum congue dolor vitae finibus. In in libero quis dui accumsan auctor. Donec imperdiet nulla non lectus mattis, lacinia efficitur est porta. Fusce nec viverra mi, sit amet condimentum ex. Morbi in sodales sapien. Duis nisl sem, malesuada eu ipsum nec, consequat efficitur nisi." },
                    { 2, 2, new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1567), "InitialCreate", true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1568), "C++ blog yorumu", "Phasellus eu auctor felis. Mauris efficitur convallis blandit. Aenean commodo velit id massa volutpat, eget interdum magna auctor. Sed laoreet urna a ipsum ultricies, eu laoreet mauris porta. Curabitur vulputate posuere ultrices. Nunc sagittis metus quis lacus aliquet, in molestie risus elementum. Proin vitae risus vitae ipsum tempus gravida quis sit amet odio. Ut elementum placerat accumsan. Ut in fringilla augue. Sed tincidunt cursus rutrum. Cras eget tristique ex. Vestibulum accumsan velit quis massa pharetra, ac malesuada ex gravida. Donec mollis et risus non convallis." },
                    { 3, 3, new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1569), "InitialCreate", true, false, "InitialCreate", new DateTime(2023, 3, 14, 22, 22, 34, 371, DateTimeKind.Local).AddTicks(1571), "java blog yorumu", "Sed nisi risus, tincidunt eu augue et, ultrices volutpat tellus. Phasellus eu erat eu elit lacinia sodales. Praesent finibus, tortor quis faucibus fringilla, ante nisl dapibus lectus, vitae lobortis augue augue cursus mauris. Cras metus turpis, aliquet in nibh non, rutrum lacinia tortor. Donec leo augue, maximus ut molestie ut, ultricies quis nunc. Sed porta dictum facilisis." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
