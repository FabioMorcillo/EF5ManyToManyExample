using System.Collections.Generic;
using ConsoleApp16.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp16.Context
{
    public class EF5DbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EF5;Integrated Security=True");

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostsTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>()
                .HasMany(e => e.Posts)
                .WithMany(e => e.Tags)
                .UsingEntity<PostTag>(
                pt => pt
                    .HasOne(p => p.Post)
                    .WithMany()
                    .HasForeignKey("PostId"),
                pt => pt
                    .HasOne(p => p.Tag)
                    .WithMany()
                    .HasForeignKey("TagId"))
                .ToTable("PostTags")
                .HasKey(pt => new { pt.PostId, pt.TagId });
        }
    }
}
