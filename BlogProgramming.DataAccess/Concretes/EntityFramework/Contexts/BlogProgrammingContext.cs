using BlogProgramming.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Concretes.EntityFramework.Contexts
{
    public class BlogProgrammingContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LENOVO\MSSQLSERVERKT;Database=ReCapDatabase;Trusted_Connection=true;
                                           Connect Timeout=30;MultipleActiveResultSets=True;");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }



    }
}
