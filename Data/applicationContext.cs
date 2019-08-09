using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PresentationCreatorWeb.Data.Models;

namespace PresentationCreatorWeb.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<UserFeature> UserFeatures { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<PresentationTag> PresentationTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=TEST;Username=test;Password=test");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFeature>()
                .HasKey(uf => new { uf.FeatureId,uf.UserId });  
            modelBuilder.Entity<UserFeature>()
                .HasOne(uf => uf.Feature)
                .WithMany(f => f.UserFeatures)
                .HasForeignKey(uf => uf.FeatureId);  
            modelBuilder.Entity<UserFeature>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.UserFeatures)
                .HasForeignKey(uf => uf.UserId);

            modelBuilder.Entity<Category>()
                .HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId);

            modelBuilder.Entity<Presentation>()
                .HasOne(p => p.CreatorUser)
                .WithMany(u => u.Presentations)
                .HasForeignKey(p => p.CreatorUserId);

            modelBuilder.Entity<Presentation>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Presentations)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<PresentationTag>()
                .HasKey(pt => new { pt.TagId,pt.PresentationId });  
            modelBuilder.Entity<PresentationTag>()
                .HasOne(pt => pt.Presentation)
                .WithMany(p => p.PresentationTags)
                .HasForeignKey(pt => pt.PresentationId);  
            modelBuilder.Entity<PresentationTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PresentationTags)
                .HasForeignKey(pt => pt.TagId);
        }
    }
}