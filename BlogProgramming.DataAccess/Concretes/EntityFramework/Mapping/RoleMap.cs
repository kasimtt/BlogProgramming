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
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r=>r.Name).HasMaxLength(100);


            /* public string Name { get; set; } 
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }*/
            
        }
    }
}
