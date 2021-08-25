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
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public BlogDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //在进行数据库迁移时会初始化到数据库
            modelBuilder.Entity<User>().HasData(new User() { Id = 1,UserName = "admin",Password = "123"}, new User() { Id = 2, UserName = "admin2", Password = "123" });
        }
    }
}
