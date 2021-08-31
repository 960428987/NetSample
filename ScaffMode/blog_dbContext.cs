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
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<StudentT> StudentTs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=blog_db", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql"));
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

            modelBuilder.Entity<StudentT>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("student_t");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_bin");

                entity.HasIndex(e => e.Code, "code_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Code)
                    .HasMaxLength(45)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");
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
