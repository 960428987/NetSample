using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityModel
{
   public class BlogDbContext:DbContext
    {
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public BlogDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().Property(b => b.Url).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.Id).HasComment("主键id");
                entity.Property(e => e.Url).HasMaxLength(100).IsRequired();
                entity.Property(e => e.CreateTime).ValueGeneratedOnAdd();
                entity.Property(e => e.LastUpdateTime).ValueGeneratedOnUpdate();
                entity.Property(e => e.Auth).HasComment("作者").HasColumnType("VARCHAR(32)");
            });
            modelBuilder.Entity<User>(entity=> {
                entity.Property(e => e.Password).HasMaxLength(100);
                entity.Property(e => e.CreateTime).ValueGeneratedOnAdd();//自动生成当前时间
            });
            modelBuilder.Entity<Book>(entity=> {
                entity.ToTable("book_t");
                entity.HasKey(e=>e.Bid);
                entity.Property(e => e.CreateTime).ValueGeneratedOnAdd();//自动生成当前时间
            });
            //在进行数据库迁移时会初始化到数据库
            modelBuilder.Entity<User>().HasData(new User() { Id = 1,UserName = "admin",Password = "123"}, new User() { Id = 2, UserName = "admin2", Password = "123" });
        }
    }
}
