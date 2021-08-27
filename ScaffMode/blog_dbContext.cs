using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ScaffMode
{
    public partial class blog_dbContext : DbContext
    {
        public blog_dbContext()
        {
        }

        public blog_dbContext(DbContextOptions<blog_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BookT> BookTs { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=blog_db;user=root;password=root@123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("blogs");

                entity.Property(e => e.Id).HasComment("主键id");

                entity.Property(e => e.Auth)
                    .HasMaxLength(32)
                    .HasComment("作者");

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.LastUpdateTime).HasMaxLength(6);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BookT>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PRIMARY");

                entity.ToTable("book_t");

                entity.Property(e => e.Bid)
                    .UseCollation("ascii_general_ci")
                    .HasCharSet("ascii");

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("posts");

                entity.HasIndex(e => e.BlogId, "IX_Posts_BlogId");

                entity.HasIndex(e => e.ContributorId, "IX_Posts_ContributorId");

                entity.HasIndex(e => e.UserIdAuthor, "IX_Posts_user_id_author");

                entity.Property(e => e.UserIdAuthor).HasColumnName("user_id_author");

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.BlogId)
                    .HasConstraintName("FK_Posts_Blogs_BlogId");

                entity.HasOne(d => d.Contributor)
                    .WithMany(p => p.PostContributors)
                    .HasForeignKey(d => d.ContributorId)
                    .HasConstraintName("FK_Posts_Users_ContributorId");

                entity.HasOne(d => d.UserIdAuthorNavigation)
                    .WithMany(p => p.PostUserIdAuthorNavigations)
                    .HasForeignKey(d => d.UserIdAuthor)
                    .HasConstraintName("FK_Posts_Users_user_id_author");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CreateTime)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
